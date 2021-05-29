# -*- coding: utf-8 -*-
"""Summary_Link.ipynb

Automatically generated by Colaboratory.

Original file is located at
    https://colab.research.google.com/drive/1dqyHrSrtHYGydm_hRBGnwLqs3p6OYrog
"""
import sys
from gensim.summarization.summarizer import summarize
from gensim.summarization import keywords
import wikipedia
import en_core_web_sm
from googlesearch import search
import argparse



def disease_info(query: str) -> (list, str):
  """Summarizes the wekipedia page of the type of disease if found and provides list of websites from google search
  Args:
    query: string that contains the plant disease to be search for
  Returns:
    sum_words: string summary of the wikipedia page if found
    urls: list of urls returned from google search"""

  assert type(query) == str, "query must be a string"
  assert len(query) > 0, "query should not be empty"

  wikicontent = wikipedia.page(query).content
  doc = (en_core_web_sm.load())(wikicontent)
  summ_words = summarize(str(doc) , word_count = 200)

  urls = []
  for url in search(query, tld="co.in", num=10, stop=10, pause=2):
      urls.append(url)

  return summ_words, urls
def main():
    print(disease_info(sys.argv[1]))

if __name__=='__main__':
    main()
