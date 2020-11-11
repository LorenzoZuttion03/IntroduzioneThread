using System;
using System.Threading; //Namespace per lavorare con i thread

namespace IntroduzioneThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prima di avviare i thread");
            MyThread tr1 = new MyThread();//Istanzio la classe che contiene i metodi da associare ai thread
            //Creo due thread associati ai due metodi della classe MyThread
            Thread t1 = new Thread(new ThreadStart(tr1.Thread1));//ThreadStart è un Delegate
            Thread t2 = new Thread(new ThreadStart(tr1.Thread2));
            //Avvio thread
            t1.Start(); // Il metodo start equivale alla Fork
            t2.Start();
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main {0}", i);
            }
            
        }
    }
    public class MyThread //Classe che contiene i thread che verranno lanciati
    {
        public void Thread1() // I thread sono metodi con void e nessun parametro
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread1 {0}", i);
            }
        }
        public void Thread2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread2 {0}", i);
            }
        }
    }
}
