let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 10 as expected

//However, if we do this:

let mutable a = 10
let mutable b = 20

let swap2 () = 
    let temp = a
    a <- b
    b <- temp

swap2 ()
printf "%d %d" a b //This will print 10 20, NOT 20 10. Why?
