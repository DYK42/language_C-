Console.WriteLine("Введите скорость первого друга!");
double speedFriend1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите скорость второго друга! Должна быть меньше скорости первого друга!");
double speedFriend2 = Convert.ToDouble(Console.ReadLine());

if(speedFriend1<speedFriend2) {
    Console.WriteLine("Неверный параметр. Попробуйте еще раз!");
    return;
}

Console.WriteLine("Введите скорость собаки! Должна быть больше скоростей обоих друзей!");
double speedDog = Convert.ToDouble(Console.ReadLine());

if(speedDog<speedFriend1 && speedDog<speedFriend2) {
    Console.WriteLine("Неверный параметр. Попробуйте еще раз!");
    return;
}