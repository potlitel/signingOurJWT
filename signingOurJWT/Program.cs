// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using signingOurJWT.Samples;

internal class Program
{
    private static void Main(string[] args)
    {
        // HMAC using SHA-256
        HmacExample.Run();

        // RSASSA-PSS using SHA-256 and MGF1 with SHA-256
        //RsaExample.Run();

        // ECDSA using P-256 and SHA-256
        //ECDsaExample.Run();
    }
}