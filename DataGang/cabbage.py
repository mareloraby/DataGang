#!/usr/bin/env</font>
 
import sys
import tensorflow as tf
import numpy as np
from tensorflow import keras
import cv2
import matplotlib.pyplot as plt
 

def preprocessing(input_tensor):
    output_tensor = tf.cast(input_tensor, dtype=tf.float32)
    output_tensor = tf.image.resize_with_pad(output_tensor, target_height=224, target_width=224)
    # output_tensor = keras.keras_applications.mobilenet.preprocess_input(output_tensor, data_format="channels_last")
    return output_tensor

model2 = keras.models.load_model('C:/Users/salma/source/repos/DataGang/my_modellr104.h5')
def make_prediction(path):
    image=cv2.imread(path)
    image =preprocessing([image])
    pred=model2.predict(image)
    classes={0:'Backmoth', 1:'Leafminer', 2:'Mildew'}
    return(classes[pred.argmax()])
def main():
    
    pat=sys.argv
    
    print(make_prediction(pat[1]))

if __name__=='__main__':
    main()