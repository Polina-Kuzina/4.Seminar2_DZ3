// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool x = false;
bool y = true;

if(! (x|y) == (! x&! y))
    Console.WriteLine("Утверждение истинно");  
else
    Console.WriteLine("Утверждение ложно");  


