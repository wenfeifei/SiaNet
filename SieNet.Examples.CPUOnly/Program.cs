﻿using CNTK;
using SiaNet;
using SiaNet.Application;
using SiaNet.Common;
using SiaNet.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieNet.Examples.CPUOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Setting global device
                GlobalParameters.Device = DeviceDescriptor.CPUDevice;
                Logging.OnWriteLog += Logging_OnWriteLog;

                /*
                 //Housing regression example
                 HousingRegression.LoadData();
                 HousingRegression.BuildModel();
                 HousingRegression.Train();

                 //MNIST Classification example
                 MNISTClassifier.LoadData();
                 MNISTClassifier.BuildModel();
                 MNISTClassifier.Train();

                 //Image classification example
                 Console.WriteLine("ResNet50 Prediction: " + ImageClassification.ImagenetTest(Common.ImageNetModel.ResNet50)[0].Name);
                 Console.WriteLine("Cifar 10 Prediction: " + ImageClassification.Cifar10Test(Common.Cifar10Model.ResNet110)[0].Name);
                 */

                //Object Detection
                //ObjectDetection.PascalDetection();
                //ObjectDetection.GroceryDetection();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }

        private void EvalImageNet()
        {

        }

        private static void Logging_OnWriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
