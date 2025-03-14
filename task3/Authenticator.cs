using System;

namespace task3
{
  public sealed class Authenticator
  {
    private static volatile Authenticator _instance; 
    private static readonly object _lock = new object(); 


    private Authenticator()
    {
      Console.WriteLine("Authenticator created.");
    }

   
    public static Authenticator Instance
    {
      get
      {
        if (_instance == null) 
        {
          lock (_lock) 
          {
            if (_instance == null) 
            {
              _instance = new Authenticator();
            }
          }
        }
        return _instance;
      }
    }

  
    
  }
}
