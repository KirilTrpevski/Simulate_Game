# Simulate_Game
Како проект ние изработивме игра која се вика Simulate. Играта се игра на следниот начин: на екранот има 4 квадратчиња кои при клик на копчето старт почнуваат да трепкаат во одреден редослед,
играчот треба да ги исклика квадратчињата по истиот редослед по кој тие трепкале, со секое наредно ниво секвенцата за погодување се зголемува за еден што ја прави играта се потешка, згора на тоа има и тајмер
кој почнува од 12 секунди и со секоја погодена секвенца се додаваат по 4 секунди, исто така со секоја погодена секвенца играчот добива по 5 поени. Играта завршува ако времето истече или доколку играчот не ја погоди
секвенцата.
![image](https://user-images.githubusercontent.com/63514637/86619212-78d0e600-bfba-11ea-8040-09857dae67b5.png)

Подоле на сликата е прикажано како трепкаат копчињата.

![image](https://user-images.githubusercontent.com/63514637/86619332-a453d080-bfba-11ea-9004-99672d31c558.png)

Овде се прикажани MessageBoxes за Game over или за продолжување на следното ниво.

![image](https://user-images.githubusercontent.com/63514637/86619403-c9e0da00-bfba-11ea-9c6c-6b036683233f.png)

#

![image](https://user-images.githubusercontent.com/63514637/86619458-e2e98b00-bfba-11ea-9ca3-51860d4dfb23.png)

### Функцијата shuffleButtons() која со секој повик ја разместува листата на копчиња за редоследот на светкање да биде различен.

```c#
  private void shuffleButtons()
        {
            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < level; i++)
            {
                randomNumbers.Add(random.Next(0, 4));
            }
            List<Button> a = new List<Button>();
            foreach (int item in randomNumbers)
            {
                a.Add(btns[item]);
            }
            pom = btns;
            btns = a;
        }
