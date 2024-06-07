Crawler crawler = new Crawler();
foreach (Cookie cookie in crawler.ImportCookies())
{
    System.Console.WriteLine(cookie.name + " " + cookie.value);
}