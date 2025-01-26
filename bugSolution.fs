let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap &x &y
printf "%d %d" x y //This will print 20 10 as expected

//Corrected version using mutable variables from outer scope

let mutable a = 10
let mutable b = 20

let swap2 () = 
    let temp = a
    a <- b
    b <- temp

swap2 ()
printf "%d %d" a b //This will now print 20 10

//Alternative solution: passing variables as arguments
let swap3 (x:byref<int>) (y:byref<int>) = 
    let temp = x
    x <- y
    y <- temp

swap3 &a &b
printf "%d %d" a b //This will also print 20 10