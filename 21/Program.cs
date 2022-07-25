double[] A = {3, 6, 8};
double[] B = {2, 1, -7};

double one = Math.Pow((A[0]-B[0]), 2);
double two = Math.Pow((A[1]-B[1]), 2);
double three = Math.Pow((A[2]-B[2]), 2);

Console.WriteLine(Math.Round(Math.Sqrt(one + two + three), 2));
