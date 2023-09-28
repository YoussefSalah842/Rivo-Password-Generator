# Rivo Password Generator

If you need to generate a bulk amount of passwords you can use one of the widely available websites, use a console generator program, or if you don't trust anyone, you can quickly write your own program. Below is the source code of a True Random password generator written entirely in C#. Compared to similar programs available on the net, which use clock-dependent C# System.Random Number Generator, this code sample uses RNGCryptoServiceProvider which is far more secure and provides unique numbers over a long period of time. Even if you won't notice the difference in generating 1-2 passwords, the RNGCryptoServiceProvider will have more even distribution for thousands of iterations.

