using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.IO;
using System.Threading;
using System.Xml.Serialization;

namespace Assessment_AandC
{
    class Program
    {
        static void Main(string[] args)
        {
            
                //List<int> num_list1 = new List<int>();
                static void Bubblesort_asc(List<int> num_list1)
                {
                    int iterations = 0;
                    int size = num_list1.Capacity;
                    for (int i = 1; i < size; i++)
                    {
                        for (int j = 0; j < (size - i); j++)
                        {
                            if (num_list1[j] > num_list1[j+1])
                            {
                                int temp = num_list1[j];
                                num_list1[j] = num_list1[j+1];
                                num_list1[j+1] = temp;
                            }
                        }

                        iterations++;
                    }
                    List<int> tenth_item = new List<int>();
                    List<int> fiftieth_item = new List<int>();
                    if (num_list1.Count > 513)
                    {
                        for (int i = 1; i < num_list1.Capacity; i++)
                        {
                        
                            if (i % 50 == 0)
                            {
                                fiftieth_item.Add(num_list1[i]);

                            }
                        }
                        Console.WriteLine(string. Join(" ", fiftieth_item));
                        Console.WriteLine($"Iterations:{iterations}");
                    }
                    else
                    {
                        for (int i = 1; i < num_list1.Capacity; i++)
                        {
                            if (i % 10 == 0)
                            {
                                tenth_item.Add(num_list1[i]);

                            }
                        }
                        Console.WriteLine(string. Join(" ", tenth_item));
                        Console.WriteLine($"Iterations:{iterations}");
                    }
                    
                    bool try_again = true;
                    while (try_again)
                    {
                        Console.WriteLine("Enter a number to find:");
                        try
                        {
                    
                            string search_number = Console.ReadLine();
                            binary_search(num_list1, Int32.Parse(search_number));
                            break;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Invalid input");
                        }
                    }
                }

                static void Bubblesort_desc(List<int> num_list2)
                {
                    int iterations = 0;
                    int size = num_list2.Capacity;
                    for (int i = 1; i < size; i++)
                    {
                        for (int j = 0; j < (size - i); j++)
                        {
                            if (num_list2[j] < num_list2[j+1])
                            {
                                int temp = num_list2[j];
                                num_list2[j] = num_list2[j+1];
                                num_list2[j+1] = temp;
                            }
                        }

                        iterations++;
                    }
                    List<int> fiftieth_item = new List<int>();
                    List<int> tenth_item = new List<int>();
                    
                    if (num_list2.Count > 513)
                    {
                        for (int i = 1; i < num_list2.Capacity; i++)
                        {
                        
                            if (i % 50 == 0)
                            {
                                fiftieth_item.Add(num_list2[i]);

                            }
                        }
                        Console.WriteLine(string. Join(" ", fiftieth_item));
                        Console.WriteLine($"Iterations:{iterations}");
                    }
                    else
                    {
                        for (int i = 1; i < num_list2.Capacity; i++)
                        {
                        
                            if (i % 10 == 0)
                            {
                                tenth_item.Add(num_list2[i]);

                            }
                        }
                        Console.WriteLine(string. Join(" ", tenth_item));
                        Console.WriteLine($"Iterations:{iterations}");
                    }
                }

                static void insertionSort_asc(List<int> num_list3, int n)
                {
                    int iterations = 0;
                    int i, key, j;
                    for (i = 1; i < n; i++)
                    {
                        key = num_list3[i];
                        j = i - 1;
                        while (j >= 0 && num_list3[j] > key)
                        {
                            num_list3[j + 1] = num_list3[j];
                            j = j - 1;
                        }
                        num_list3[j + 1] = key;
                        iterations++;
                    }
                    List<int> fiftieth_item = new List<int>();
                    List<int> tenth_item = new List<int>();
                    
                    if (num_list3.Count > 513)
                    {
                        for (int k = 1; k < num_list3.Capacity; k++)
                        {
                        
                            if (k % 50 == 0)
                            {
                                fiftieth_item.Add(num_list3[k]);

                            }
                        }
                        Console.WriteLine(string. Join(" ", fiftieth_item));
                        Console.WriteLine($"Iterations:{iterations}");
                    }
                    else
                    {
                        for (int k = 1; k < num_list3.Capacity; k++)
                        {
                        
                            if (k % 10 == 0)
                            {
                                tenth_item.Add(num_list3[k]);

                            }
                        }
                        Console.WriteLine(string. Join(" ", tenth_item));
                        Console.WriteLine($"Iterations:{iterations}");
                    }
                    bool try_again = true;
                    while (try_again)
                    {
                        Console.WriteLine("Enter a number to find:");
                        try
                        {
                    
                            string search_number = Console.ReadLine();
                            linear_search(num_list3,num_list3.Count,Int32.Parse(search_number));
                            break;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Invalid input");
                        }
                    }
                }

                static void insertionSort_desc(List<int> num_list4, int n)
                {
                    int iterations = 0;
                    int i, key, j;
                    for (i = 1; i < n; i++)
                    {
                        key = num_list4[i];
                        j = i - 1;
                        while (j >= 0 && num_list4[j] > key)
                        {
                            num_list4[j + 1] = num_list4[j];
                            j = j - 1;
                        }
                        num_list4[j + 1] = key;
                        iterations++;
                    }

                    num_list4.Reverse();
                    
                    List<int> fiftieth_item = new List<int>();
                    List<int> tenth_item = new List<int>();
                    
                    if (num_list4.Count > 513)
                    {
                        for (int k = 1; k < num_list4.Capacity; k++)
                        {
                        
                            if (k % 50 == 0)
                            {
                                fiftieth_item.Add(num_list4[k]);

                            }
                        }
                        Console.WriteLine(string. Join(" ", fiftieth_item));
                        Console.WriteLine($"Iterations:{iterations}");
                    }
                    else
                    {
                        for (int k = 1; k < num_list4.Capacity; k++)
                        {
                        
                            if (k % 10 == 0)
                            {
                                tenth_item.Add(num_list4[k]);

                            }
                        }
                        Console.WriteLine(string. Join(" ", tenth_item));
                        Console.WriteLine($"Iterations:{iterations}");
                    }
                }
                
                static void binary_search(List<int> sorted_list,int key)
                {
                    int minNum = 0;
                    int maxNum = sorted_list.Count - 1;
                    bool found = false;
                    int lower_val = 0;
                    int higher_val = 0;
                    int steps = 0;

                    while (minNum <=maxNum)
                    {
                        steps++;
                        int mid = (minNum + maxNum) / 2;
                        if (key == sorted_list[mid])
                        {
                            int index = mid;
                            Console.WriteLine($"Number found in list at index {index} (Binary search)");
                            Console.WriteLine($"Steps taken: {steps}");
                            found = true;
                            break;
                        } 
                        else if (key < sorted_list[mid]) 
                        {
                            maxNum = mid - 1;
                        }
                        else 
                        {
                            minNum = mid + 1;
                        }

                        lower_val = sorted_list[mid];
                        higher_val = sorted_list[mid + 1];
                    }
                    if (found == true)
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine("Not found in list (Binary search)");
                        Console.WriteLine($"Clostest value lower is {lower_val}");
                        Console.WriteLine($"Clostest value higher is {higher_val}");
                        Console.WriteLine($"Steps taken: {steps}");
                    }
                }

                static void linear_search(List<int> list1, int listLen, int num)
                {
                    bool found = false;
                    int index = 0;
                    int steps = 0;
                    for (int i = 0; i < listLen; i++)
                    {
                        steps++;
                        if (list1[i] == num)
                        {
                            found = true;
                            index = i;
                            break;
                        }
                    }

                    if (found == true)
                    {
                        Console.WriteLine($"Number found at index {index} (Linear search)");
                        Console.WriteLine($"Steps taken: {steps}");
                    }
                    else
                    {
                        Console.WriteLine("Number not found in list (Linear search)");
                        Console.WriteLine($"Steps taken: {steps}");
                    }
                }
                
            

            List<int> share1_256 = File.ReadLines("..\\..\\..\\Share_1_256.txt").ToArray()
                .Select(l => Convert.ToInt32(l))
                .ToList();

            List<int> share2_256 = File.ReadLines("..\\..\\..\\Share_2_256.txt").ToArray()
                .Select(l => Convert.ToInt32(l))
                .ToList();

            List<int> share3_256 = File.ReadLines("..\\..\\..\\Share_3_256.txt").ToArray()
                .Select(l => Convert.ToInt32(l))
                .ToList();

            List<int> share1_2048 = File.ReadLines("..\\..\\..\\Share_1_2048.txt").ToArray()
                .Select(l => Convert.ToInt32(l))
                .ToList();

            List<int> share2_2048 = File.ReadLines("..\\..\\..\\Share_2_2048.txt").ToArray()
                .Select(l => Convert.ToInt32(l))
                .ToList();

            List<int> share3_2048 = File.ReadLines("..\\..\\..\\Share_3_2048.txt").ToArray()
                .Select(l => Convert.ToInt32(l))
                .ToList();

            List<int> share1_3_256 = new List<int>();
            share1_3_256.AddRange(share1_256);
            share1_3_256.AddRange(share3_256);
            
            List<int> share1_3_2048 = new List<int>();
            share1_3_2048.AddRange(share1_2048);
            share1_3_2048.AddRange(share3_2048);
            
            Console.WriteLine("\nBubble sort ascending order Share_1_256.txt (Every 10th item):");
            Bubblesort_asc(share1_256);
            Console.WriteLine("Bubble sort descending order Share_1_256.txt (Every 10th item):");
            Bubblesort_desc(share1_256);
            Thread.Sleep(3000);
            
            Console.WriteLine("\nInsertion sort ascending order Share_2_256.txt (Every 10th item):");
            insertionSort_asc(share2_256,share2_256.Count);
            Console.WriteLine("Insertion sort descending order Share_2_256.txt (Every 10th item):");
            insertionSort_desc(share2_256,share2_256.Count);
            Thread.Sleep(3000);
        
            Console.WriteLine("\nBubble sort ascending order Share_3_256.txt (Every 10th item):");
            Bubblesort_asc(share3_256);
            Console.WriteLine("Bubble sort descending order Share_3_256.txt (Every 10th item):");
            Bubblesort_desc(share3_256);
            Thread.Sleep(3000);
            
            Console.WriteLine("\nBubble sort ascending order Share_1_256.txt and Share_3_256.txt (Every 10th item):");
            Bubblesort_asc(share1_3_256);
            Console.WriteLine("Bubble sort descending order Share_1_256.txt and Share_3_256.txt (Every 10th item):");
            Bubblesort_desc(share1_3_256);
            Thread.Sleep(3000);

            Console.WriteLine("\nBubble sort ascending order Share_1_2048.txt (Every 50th item):");
            Bubblesort_asc(share1_2048);
            Console.WriteLine("Bubble sort descending order Share_1_2048.txt (Every 50th item):");
            Bubblesort_desc(share1_2048);
            Thread.Sleep(3000);
            
            Console.WriteLine("\nInsertion sort ascending order Share_2_2048.txt (Every 50th item):");
            insertionSort_asc(share2_2048,share2_2048.Count);
            Console.WriteLine("Insertion sort descending order Share_2_2048.txt (Every 50th item):");
            insertionSort_desc(share2_2048,share2_2048.Count);
            Thread.Sleep(3000);
        
            Console.WriteLine("\nBubble sort ascending order Share_3_2048.txt (Every 50th item):");
            Bubblesort_asc(share3_2048);
            Console.WriteLine("Bubble sort descending order Share_3_2048.txt (Every 50th item):");
            Bubblesort_desc(share3_2048);
            Thread.Sleep(3000);

            Console.WriteLine("\nBubble sort ascending order Share_1_2048.txt and Share_3_2048.txt (Every 50th item):");
            Bubblesort_asc(share1_3_2048);
            Console.WriteLine("Bubble sort descending order Share_1_2048.txt and Share_3_2048.txt (Every 50th item):");
            Bubblesort_desc(share1_3_2048);
        }
    }
}
