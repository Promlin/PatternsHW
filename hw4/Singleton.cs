using System;


namespace hw4
{
    class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public static void printStringInSingleton()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.Write("Singleton i " + i);
            }
        }
    }
}
