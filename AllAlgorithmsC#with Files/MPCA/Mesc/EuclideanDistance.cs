﻿using FaceRecognitionAlgorithms;
using DotNetMatrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognitionAlgorithms
{
   public class EuclideanDistance : Metric 
   {
        public double getDistance(Matrix a, Matrix b) 
        {
	        int size = a.RowDimension;
	        double sum = 0;

	        for (int i = 0; i < size; i++) 
            {
                double dif = a.GetElement(i, 0) - b.GetElement(i, 0) ;
                sum += dif * dif ;
	        }
	        return Math.Sqrt(sum);
        }
   }
}