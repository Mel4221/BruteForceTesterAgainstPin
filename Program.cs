//
// ${Melquiceded Balbi Villanueva}
//
// Author:
//       ${Melquiceded} <${melquiceded.balbi@gmail.com}>
//
// Copyright (c) ${2089} MIT
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.Diagnostics;
using QuickTools;
using static QuickTools.Color;
namespace BruteForce
{
      class MainClass
      {
            public static void Main(string[] args)
            {
                  Options.Label = "This is just a test to see how long it can take to break a pin based on it's lenght ";
                  string[] options = { "Break Pin" }; 
                  var option = new Options(options);
                  switch(option.Pick())
                  {
                        case 0:
                              FindPin(); 
                              break;
                       
                  }
            }

        
            public static void FindPin()
            {
                  Stopwatch stopwatch = new Stopwatch();

                  stopwatch.Start();


                  Get.Green("Type a pin if you want to test it ");
            
                  int code = Get.NumberInput();
                  int x = 0;
                  int atempts = 0;
                  while (x != code)
                  {
                        x = int.Parse(New.Pin(code.ToString().Length));
                        Green($"Looking For: {code}");
                        Yellow($"Brute Force: {x}");
                        atempts++;
                        Log.Event("BruteForce", $"Looking For: {code} X: {x} Attempt: {atempts}");
                  }

                  TimeSpan time = stopwatch.Elapsed;
                  stopwatch.Stop();

                  string statics = $"Pin: {code} X: {x} Atempts Taken: {atempts}"; 
                  string results = $"{statics}  Min {time.Minutes}   : Sec {time.Seconds}";
                  Color.Red(results);
                  Log.Event("BruteForceHistory", results);

            }
      }
}
