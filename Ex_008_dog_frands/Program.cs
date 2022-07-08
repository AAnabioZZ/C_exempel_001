int count = 0;
int dist = 10000;
int ffspeed = 1;
int sfspeed = 2;
int dogSpeed = 5;
int frend = 2;
int time = 0;

 while (dist > 10){

    if(frend == 1){

        time = dist/(ffspeed+dogSpeed);
        frend = 2;

    }else {

        time = dist/(sfspeed+dogSpeed);
        frend =1;

    } 

    dist= dist - (ffspeed + sfspeed)*time;
    count++;

}

Console.WriteLine(count);
