using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMeme
{
    public static class RandomNumber
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        public static Random Random
        {
            get
            {
                return random;
            }
        }
        public static object SyncLock
        {
            get
            {
                return syncLock;
            }
        }

        //Generate a random number between 1 and the number of files inside the folder
        public static int RandomMemeNumber(int number_files)
        {
            lock (SyncLock)
            { // synchronize
                return Random.Next(1, number_files);
            } 
        }
    }
}
