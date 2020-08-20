
# # Text Summarization in Python


# ## Implementation

# ### 1. Importing important libraries


# numpy library helps in working with arrays: array creation and manipulation
# this implementation uses array for storing the matrices generated as 2-D arrays
# PyPDF2 is a library used for reading the PDF files
# sys library has been used for printing the size of data structures used in the program
import numpy as np
import PyPDF2
import sys


import matplotlib.pyplot as plt
#get_ipython().magic('matplotlib inline')

import networkx as nx

from nltk.tokenize.punkt import PunktSentenceTokenizer


from sklearn.feature_extraction.text import TfidfTransformer, CountVectorizer


# ### 2.  Function to read the document from user

def readDoc():
    name = input('Please input a file name: ') 
    print('You have asked for the document {}'.format(name))
    print("\n")

    # now read the type of document
    if name.lower().endswith('.txt'):
        choice = 1
    elif name.lower().endswith('.pdf'):
        choice = 2
    else:
        choice = 3
        # print(name)
    print(choice)
    # Case 1: if it is a .txt file
        
    if choice == 1:
        f = open(name, 'r')
        document = f.read()
        f.close()
            
    # Case 2: if it is a .pdf file
    elif choice == 2:
        pdfFileObj = open(name, 'rb')
        pdfReader = PyPDF2.PdfFileReader(pdfFileObj)
        pageObj = pdfReader.getPage(0)
        document = pageObj.extractText()
        pdfFileObj.close()
    
    # Case 3: none of the format
    else:
        print('Failed to load a valid file')
        print('Returning an empty string')
        document = ''
    
    print(type(document))
    print("\n")
    return document


# ### 3. Function to tokenize the document

def tokenize(document):
  
    doc_tokenizer = PunktSentenceTokenizer()
    
    sentences_list = doc_tokenizer.tokenize(document)
    return sentences_list


# ### 4. Read the document


document = readDoc()
print('The length of the file is:', end=' ')
print(len(document))
print("\n")


# ### 5. Generate a list of sentences in the document

sentences_list = tokenize(document)

# let us print the size of memory used by the list sentences
print('The size of the list in Bytes is: {}'.format(sys.getsizeof(sentences_list)))

print("\n")

print("\n")


# the size of one of the element of the list
print('The size of the item 0 in Bytes is: {}'.format(sys.getsizeof(sentences_list[0])))

print("\n")
# In[82]:

# let us see the data type of sentences_list
# It will be list
print(type(sentences_list))

print("\n")

print("\n")



# let us analyse the elements of the sentences
# len() method applies on the list and provides the number of elements in the list
print('The size of the list "sentences" is: {}'.format(len(sentences_list)))

print("\n")
print("\n")

for i in sentences_list:
    print(i)

print("\n")
print("\n")
# ### 6. Generate term-document matrix (TD matrix) of the data 

cv = CountVectorizer()
cv_matrix = cv.fit_transform(sentences_list)



cv_demo = CountVectorizer() # a demo object of class CountVectorizer

# I have repeated the words to make a non-ambiguous array of the document text matrix 

text_demo = ["Ashish is good, you are bad", "I am not bad"] 
res_demo = cv_demo.fit_transform(text_demo)
print('Result demo array is {}'.format(res_demo.toarray()))
print("\n")
print("\n")

print('Feature list: {}'.format(cv_demo.get_feature_names()))
print("\n")
print("\n")


print('The data type of bow matrix {}'.format(type(cv_matrix)))
print("\n")
print("\n")
print('Shape of the matrix {}'.format(cv_matrix.get_shape))
print("\n")
print("\n")
print('Size of the matrix is: {}'.format(sys.getsizeof(cv_matrix)))
print("\n")
print("\n")
print(cv.get_feature_names())
print("\n")
print("\n")
print(cv_matrix.toarray())
print("\n")
print("\n")



normal_matrix = TfidfTransformer().fit_transform(cv_matrix)
print(normal_matrix.toarray())
print("\n")
print("\n")



print(normal_matrix.T.toarray)
print("\n")
print("\n")
res_graph = normal_matrix * normal_matrix.T


nx_graph = nx.from_scipy_sparse_matrix(res_graph)
nx.draw_circular(nx_graph)
print('Number of edges {}'.format(nx_graph.number_of_edges()))
print("\n")
print("\n")
print('Number of vertices {}'.format(nx_graph.number_of_nodes()))
print("\n")
print("\n")
# plt.show()
print('The memory used by the graph in Bytes is: {}'.format(sys.getsizeof(nx_graph)))

print("\n")
print("\n")


print(type(ranks))
print("\n")
print("\n")

print('The size used by the dictionary in Bytes is: {}'.format(sys.getsizeof(ranks)))
print("\n")

for i in ranks:
    print(i, ranks[i])
print("\n")
print("\n")




sentence_array = sorted(((ranks[i], s) for i, s in enumerate(sentences_list)), reverse=True)
sentence_array = np.asarray(sentence_array)




rank_max = float(sentence_array[0][0])
rank_min = float(sentence_array[len(sentence_array) - 1][0])



print(rank_max)
print("\n")
print("\n")
print(rank_min)

print("\n")
print("\n")


temp_array = []


flag = 0
if rank_max - rank_min == 0:
    temp_array.append(0)
    flag = 1

# If the sentence has different ranks
if flag != 1:
    for i in range(0, len(sentence_array)):
        temp_array.append((float(sentence_array[i][0]) - rank_min) / (rank_max - rank_min))

print(len(temp_array))
print("\n")
print("\n")

 
threshold = (sum(temp_array) / len(temp_array)) + 0.2



sentence_list = []
if len(temp_array) > 1:
    for i in range(0, len(temp_array)):
        if temp_array[i] > threshold:
                sentence_list.append(sentence_array[i][1])
else:
    sentence_list.append(sentence_array[0][1])




model = sentence_list


summary = " ".join(str(x) for x in sentence_list)
print(summary)

f = open('sum.txt', 'a+')
#print(type(f))
f.write('-------------------\n')
f.write(summary)
f.write('\n')

f.close



for lines in sentence_list:
    print(lines)



