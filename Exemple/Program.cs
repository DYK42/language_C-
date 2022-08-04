Console.WriteLine("Введите скорость первого друга!");
double speedFriend1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите скорость второго друга! Должна быть меньше скорости первого друга! {speedFriend1}");
double speedFriend2 = Convert.ToDouble(Console.ReadLine());

if(speedFriend1<speedFriend2) {
    Console.WriteLine("Неверный параметр. Попробуйте еще раз!");
    return;
}

Console.WriteLine($"Введите скорость собаки! Должна быть больше скоростей обоих друзей! {speedFriend1} / {speedFriend2}");
double speedDog = Convert.ToDouble(Console.ReadLine());

if(speedDog<speedFriend1 && speedDog<speedFriend2) {
    Console.WriteLine("Неверный параметр. Попробуйте еще раз!");
    return;
}

Console.WriteLine("Введите расстояние между друзьями!");
double distance = Convert.ToDouble(Console.ReadLine());

if(distance <= 10) 
    Console.WriteLine("Друзья уже встретились!");

int count = 0;
int friend = 1;
double time = 0;

while(distance > 10) {
    if(friend == 1) {
        time = distance / (speedDog - speedFriend2);
        friend = 2;
    } else {
        time = distance / (speedDog + speedFriend1);
        friend = 1;
    }
    distance -= (speedFriend1 - speedFriend2) * time;
    count += 1;
}

Console.Write($"Собака сделает кругов: {count}");