module Leap

let leapYear (year: int): bool =
    let currYear: int = year
    let mutable result: bool = false
    let mutable div4: int = 0
    let mutable div100: int = 0
    let mutable div400: int = 0
    div4 <- currYear % 4
    result <- if div4 = 0 then true else false
    if (result) then
        (div100 <- currYear % 100
         result <- if div100 = 0 then false else true
         if (not result) then
             (div400 <- currYear % 400
              result <- if div400 = 0 then true else false))
    result
