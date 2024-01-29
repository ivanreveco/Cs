///lambda 

Some((a, b) => a + b, 5);

void Some(Func <int,int,int> fn , int number) {
    var result = fn(number, number);
}

Console.WriteLine
