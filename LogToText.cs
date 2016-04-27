﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageImporterLibrary
{
    /// <summary>
    /// This logs information to the text file. Can be used everywhere.
    /// </summary>
    public class LogToText
    {
        /// <summary>
        /// Constant filename where information will be logged to.
        /// </summary>
        private const string FileName = "LogFile.txt";

        /// <summary>
        /// The write to log.
        /// </summary>
        /// <param name="inputText">
        /// The input text.
        /// </param>
        public static void WriteToLog(string inputText)
        {
            if (File.Exists(FileName))
            {
                WriteStream(FileName, inputText);
                return;
            }
            else
            {
                var createFile = File.CreateText(FileName);
                createFile.Close();

                WriteStream(FileName, inputText);
            }

        }

        /// <summary>
        /// This executes the stream writer to add a new line in to the text file.
        /// </summary>
        /// <param name="fileName">
        /// The file Name specified in WriteToLog method.
        /// </param>
        /// <param name="inputText">
        /// The input Text which is handled via the WriteToLog method.
        /// </param>
        private static void WriteStream(string fileName, string inputText)
        {
            try
            {
                using (StreamWriter writeFile = new StreamWriter(fileName, true))
                {
                    writeFile.WriteLine($"{DateTime.Now} \t {inputText}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }

}

