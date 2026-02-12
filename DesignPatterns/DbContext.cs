namespace DesignPatterns;

public class DbContext
{
   private static DbContext? _instance  ; 

   private  static readonly object _lock = new object();

    public static DbContext Instance()
    {
        lock (_lock)
        {
            
            if(_instance == null)
            {
                _instance = new DbContext();
            }
        }
        return _instance; 
    }

   private DbContext() { }


        public void SaveChanges()
        {
            Console.WriteLine("Changes saved to the database");
        }


        public bool connected()
        {
            return true; 
        }


        public object ExecutedAsRead(string query)
        {
            Console.WriteLine($"Executed query: {query}");
            return true; 
        }

        public object ExecutedAsWrite(string query)
        {
            Console.WriteLine($"Executed query: {query}");
            return true; 
        }

        public void Dispose()
        {
            Console.WriteLine("DbContext disposed");
        }
}

