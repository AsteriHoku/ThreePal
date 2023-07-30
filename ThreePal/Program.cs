
using System.Diagnostics;
using System.Text;

Console.WriteLine("Hallo, World!");

var t0 = new Stopwatch();
t0.Start();
var answer = 0;
for (var i = 100; i < 1000; i++)
{
    for (var j = 100; j < 1000; j++)
    {
        var num = i * j;
        var og = num;
        var rev = 0;
        while (num > 0)
        {
            var remainder = num % 10;
            rev = (rev * 10) + remainder;
            num /= 10;
        }

        if (og == rev && og > answer)
        {
            answer = og;
        }
    }
}

t0.Stop();
Console.WriteLine(t0.ElapsedMilliseconds);
// Console.WriteLine($"v1 numbers took {t0.ElapsedMilliseconds} MS");

var t2 = new Stopwatch();
t2.Start();
var answer3 = 0;
for (int m = 100; m < 1000; m++)
{
    for (int n = 100; n < 1000; n++)
    {
        var num = m * n;
        var ns = num.ToString();
        var nsr = new string(ns.ToCharArray().Reverse().ToArray());

        if (ns == nsr && num > answer3)
        {
            answer3 = num;
        }
    }
}

t2.Stop();
Console.WriteLine(t2.ElapsedMilliseconds);
// Console.WriteLine($"v3 char array and linq took {t2.ElapsedMilliseconds} MS");

var t3 = new Stopwatch();
t3.Start();
var answer4 = 0;
for (var o = 100; o < 1000; o++)
{
    for (var p = 100; p < 1000; p++)
    {
        var num = p * o;
        var s = num.ToString();
        var r = "";
        var length = s.Length - 1;

        while (length >= 0)
        {
            r += s[length];
            length--;
        }

        if (r == s && num > answer4)
        {
            answer4 = num;
        }
    }
}

t3.Stop();
Console.WriteLine(t3.ElapsedMilliseconds);
// Console.WriteLine($"v4 while loop with poor string usage took {t3.ElapsedMilliseconds} MS");

var t4 = new Stopwatch();
t4.Start();
var answer5 = 0;
for (var o = 100; o < 1000; o++)
{
    for (var p = 100; p < 1000; p++)
    {
        var num = p * o;
        var s = num.ToString();
        var sb = new StringBuilder();
        var length = s.Length - 1;

        while (length >= 0)
        {
            sb.Append(s[length]);
            length--;
        }

        if (sb.ToString() == s && num > answer5)
        {
            answer5 = num;
        }
    }
}

t4.Stop();
Console.WriteLine(t4.ElapsedMilliseconds);
// Console.WriteLine($"v5 while loop with sb took {t4.ElapsedMilliseconds} MS");

var t5 = new Stopwatch();
t5.Start();
var answer6 = 0;
for (var o = 100; o < 1000; o++)
{
    for (var p = 100; p < 1000; p++)
    {
        var num = p * o;
        var s = num.ToString();
        var r = "";

        for (var t = s.Length - 1; t >= 0; t--)
        {
            r += s[t];
        }

        if (r == s && num > answer6)
        {
            answer6 = num;
        }
    }
}

t5.Stop();
Console.WriteLine(t5.ElapsedMilliseconds);
// Console.WriteLine($"v6 for loop with poor string usage took {t5.ElapsedMilliseconds} MS");

var t6 = new Stopwatch();
t6.Start();
var answer7 = 0;
for (var o = 100; o < 1000; o++)
{
    for (var p = 100; p < 1000; p++)
    {
        var num = p * o;
        var s = num.ToString();
        var sb = new StringBuilder();

        for (var q = s.Length - 1; q >= 0; q--)
        {
            sb.Append(s[q]);
        }

        if (sb.ToString() == s && num > answer7)
        {
            answer7 = num;
        }
    }
}

t6.Stop();
Console.WriteLine(t6.ElapsedMilliseconds);
// Console.WriteLine($"v7 for loop with sb took {t6.ElapsedMilliseconds} MS");