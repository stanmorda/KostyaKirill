// See https://aka.ms/new-console-template for more information


var test = new YandexTest();

Thread.Sleep(100);
Console.WriteLine("Hello, World!");

class YandexTest
{
    private List<string> _result = new List<string>();
    private readonly object _syncResult = new object();
    
    void DoWork(object url)
    {
        try
        {
            var httpClient = new HttpClient();
            var data = httpClient.GetAsync((string)url).GetAwaiter().GetResult();
            var str = data.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            lock (_syncResult)
            {
                _result.Add(str);
            }
        }
        catch (ThreadInterruptedException e)
        {
            // ignore
            Console.WriteLine("Thread was aborted!");
        }
    }

    public List<string> Result => _result;
    
    public YandexTest()
    {
        var t1 = new Thread(DoWork);
        t1.Name = "ya";
        
        var t2 = new Thread(DoWork);
        t2.Name = "yandex";
        
        t1.Start("http://ya.ru");
        t2.Start("http://yandex.ru");
    }
}