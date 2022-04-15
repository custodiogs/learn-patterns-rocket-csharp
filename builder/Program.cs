var rocket = RocketBuilder.Configure()
    .SetMaxWeight(3000)
    .SetMaxSpeed(33000);

Console.WriteLine("Rocket Setup \n Max Weight: {0} \n Max Speed: {1}", rocket.GetMaxSpeed(), rocket.GetMaxWeight());
