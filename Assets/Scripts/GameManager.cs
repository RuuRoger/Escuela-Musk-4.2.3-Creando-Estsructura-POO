using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Public Proiperties
    public Pet bear;
    public Pet cat;
    public Pet rabbit;

    public Food donut;
    public Food meat;
    public Food watermelon;

    public Toy ball;
    public Toy doll;
    public Toy stick;

    public bool showBear;
    public bool showCat;
    public bool showRabbit;
    public bool selectDonut;
    public bool selectMeat;
    public bool selectWatermelon;
    public bool selectBall;
    public bool selectDoll; 
    public bool selectStick;

    //Private attributes
    private sbyte _operation;
    private string _activePet;

    //Methods

    private void Start()
    {
        //Booleans as false
        showBear = false;
        showCat = false;
        showRabbit = false;

        //Active Objects as false
        bear.gameObject.SetActive(false);
        cat.gameObject.SetActive(false);
        rabbit.gameObject.SetActive(false);

        //Atribute _activePet
        _activePet = "";


    }

    private void Update()
    {
        //Buttons
        if (showBear)
        {
            bear.gameObject.SetActive(true);
            cat.gameObject.SetActive(false);
            rabbit.gameObject.SetActive(false);
            showBear = false;
        }

        if (showCat)
        {   
            cat.gameObject.SetActive(true);
            bear.gameObject.SetActive(false);
            rabbit.gameObject.SetActive(false);
            showCat = false;
        }

        if (showRabbit)
        {
            rabbit.gameObject.SetActive(true);
            bear.gameObject.SetActive(false);
            cat.gameObject.SetActive(false);
            showRabbit = false;
        }

        Feed();
        PlayWithPet();

    }

    private void Feed()
    {
        if (selectDonut)
        {
            if (bear.gameObject.activeSelf) _activePet = "Bear";
            if (cat.gameObject.activeSelf) _activePet = "Cat";
            if (rabbit.gameObject.activeSelf) _activePet = "Rabbit";

            switch (_activePet)
            {
                case "Bear":
                    _operation = bear.hunger -= donut.hunguerLevel;
                    if (_operation <=0)
                    {
                        bear.hunger = 0;
                        print("¡" + bear.petName + " está llena!");
                    }
                    else
                    {
                        print("Donut comido.");
                        print("Cantidad de hambre de " + bear.petName + ": " + bear.hunger);
                    }
                    selectDonut = false;
                    break;
                case "Cat":
                    _operation = cat.hunger -= donut.hunguerLevel;
                    if (_operation <= 0)
                    {
                        cat.hunger = 0;
                        print("¡" + cat.petName + " está lleno!");
                    }
                    else
                    {
              
                        print("Donut Comido");
                        print("Cantidad de hambre de " + cat.petName + " :" + cat.hunger);
                    }
                    selectDonut = false;
                    break;

                case "Rabbit":
                    _operation = rabbit.hunger -= donut.hunguerLevel;
                    if (_operation<= 0 )
                    {
                        rabbit.hunger = 0;
                        print("¡" + rabbit.petName + " está lleno!");
                    }
                    else
                    {

                        print("Donut comido");
                        print("Cantidad de hambre de " + rabbit.petName + ": " + rabbit.hunger);
                    }
                    selectDonut = false;
                    break;

                default:
                    print("Algo falla...");
                    selectDonut = false;
                    break;

            }
        }
        if (selectMeat)
        {
            if (bear.gameObject.activeSelf) _activePet = "Bear";
            if (cat.gameObject.activeSelf) _activePet = "Cat";
            if (rabbit.gameObject.activeSelf) _activePet = "Rabbit";

            switch (_activePet)

            {
                case "Bear":
                    _operation = bear.hunger -= meat.hunguerLevel;
                    if (_operation <= 0)
                    {
                        bear.hunger = 0;
                        print("¡" + bear.petName + " está llena!");
                    }
                    else
                    {
                        print("Carne comida.");
                        print("Cantidad de hambre de " + bear.petName + ": " + bear.hunger);
                    }
                    selectMeat = false;
                    break;

                case "Cat":
                    _operation = cat.hunger -= meat.hunguerLevel;
                    if (_operation <= 0 )
                    {
                        cat.hunger = 0;
                        print("¡" + cat.petName + " está lleno!");
                    }
                    else
                    {
                   
                        print("Carne comida.");
                        print("Cantidad de hambre de " + cat.petName + ": " + cat.hunger);
                    }
                    selectMeat = false;
                    break;

                case "Rabbit":
                    _operation = rabbit.hunger -= meat.hunguerLevel;
                    if (_operation <= 0)
                    {
                        rabbit.hunger = 0;
                        print("¡" + rabbit.petName + " está lleno!");
                    }
                    else
                    {
              
                        print("Carne comida.");
                        print("Cantidad de hambre de " + rabbit.petName + ": " + rabbit.hunger);
                    }
                    selectMeat = false;
                    break;

                default:
                    print("Algo falla...");
                    selectMeat = false;
                    break;

            }
        }
        if (selectWatermelon) 
        {
            if (bear.gameObject.activeSelf) _activePet = "Bear";
            if (cat.gameObject.activeSelf) _activePet = "Cat";
            if (rabbit.gameObject.activeSelf) _activePet = "Rabbit";

            switch (_activePet)
            {
                case "Bear":
                    _operation = bear.hunger -= watermelon.hunguerLevel;
                    if (_operation <= 0)
                    {
                        bear.hunger = 0;
                        print("¡" + bear.petName + " está llena!");
                    }
                    else
                    {
                        print("Sandía comida.");
                        print("Cantidad de hambre de " + bear.petName + ": " + bear.hunger);
                    }
                    selectWatermelon = false;
                    break;

                case "Cat":
                    _operation = cat.hunger -= watermelon.hunguerLevel;
                    if (_operation <= 0)
                    {
                        cat.hunger = 0;
                        print("¡" + cat.petName + " está lleno!");
                    }
                    else
                    {
                        print("Sandía comida.");
                        print("Cantidad de hambre de " + cat.petName + ": " + cat.hunger);
                    }
                    selectWatermelon = false;
                    break;

                case "Rabbit":
                    _operation = rabbit.hunger -= watermelon.hunguerLevel;
                    if (_operation <= 0)
                    {
                        rabbit.hunger = 0;
                        print("¡" + rabbit.petName + " está lleno!");
                    }
                    else
                    {
                        print("Sandía comida.");
                        print("Cantidad de hambre de " + rabbit.petName + ": " + rabbit.hunger);
                    }
                    selectWatermelon = false;
                    break;

                default:
                    print("Algo falla...");
                    selectWatermelon = false;
                    break;
            }
        }
    }

    private void PlayWithPet ()
    {
        if (selectBall)
        {
            if (bear.gameObject.activeSelf) _activePet = "Bear";
            if (cat.gameObject.activeSelf) _activePet = "Cat";
            if (rabbit.gameObject.activeSelf) _activePet = "Rabbit";

            switch (_activePet)
            {
                case "Bear":
                    _operation = bear.happiness += ball.happinessLevel;
                    if (_operation >= 100)
                    {
                        bear.happiness = 100;
                        print("¡" + bear.petName + " ha jugado demasiado!");
                    }
                    else
                    {
                        print("Pelota usada.");
                        print("Cantidad de felicidad de " + bear.petName + ":" + "" + bear.happiness);
                    }
                    selectBall = false;
                    break;

                case "Cat":
                    _operation = cat.happiness += ball.happinessLevel;
                    if (_operation >= 100)
                    {
                        cat.happiness = 100;
                        print("¡" + cat.petName + "ha jugado demasiado!");
                    }
                    else
                    {
                        print("Pelota usada");
                        print("Cantidad de felicidad de " + cat.petName +":" + cat.happiness);
                    }
                    selectBall = false; 
                    break;

                case "Rabbit":
                    _operation = rabbit.happiness += ball.happinessLevel;
                    if (_operation >= 100)
                    {
                        rabbit.happiness = 100;
                        print("¡" + rabbit.petName + "ha jugado demasiado!");
                    }
                    else
                    {
                        print("Pelota");
                        print("Cantidad de felicidad de " + rabbit.petName + ":" + rabbit.happiness);
                    }
                    selectBall = false;
                    break;
                default:
                    {
                        print("Algo falla...");
                        selectBall = false;
                        break;
                    }
            }
        }
        if (selectDoll)
        {
            if (bear.gameObject.activeSelf) _activePet = "Bear";
            if (cat.gameObject.activeSelf) _activePet = "Cat";
            if (rabbit.gameObject.activeSelf) _activePet = "Rabbit";

            switch(_activePet)
            {
                case "Bear":
                    _operation = bear.happiness += doll.happinessLevel;
                    if (_operation >= 100)
                    {
                        bear.happiness = 100;
                        print("¡" + bear.petName + "ha jugado demasiado!");
                    }
                    else
                    {
                        print("Muñeca usada.");
                        print("Cantidad de felicidad de " + bear.petName +":" + bear.happiness);
                    }
                    selectDoll = false; 
                    break;

                case "Cat":
                    _operation = cat.happiness += doll.happinessLevel;
                    if (_operation >= 100)
                    {
                        cat.happiness = 100;
                        print("¡" + cat.petName + "ha jugado demasiado!");
                    }
                    else
                    {
                        print("Muñeca usada.");
                        print("Cantidad de felicidad de " + cat.petName + ":" +  cat.happiness);
                    }
                    selectDoll = false;
                    break;

                case "Rabbit":
                    _operation = rabbit.happiness += doll.happinessLevel;
                    if( _operation >= 100)
                    {
                        rabbit.happiness = 100;
                        print("¡" + rabbit.petName + "ha jugado demasiado!");
                    }
                    else
                    {
                        print("Muñeca usada.");
                        print("Cantidad de felicidad de " + rabbit.petName + ":" + rabbit.happiness);
                    }
                    selectDoll = false;
                    break;

                default:
                    {
                        print("Algo falla...");
                        selectDoll = false;
                        break;
                    }
            }
        }
        if (selectStick)
        {
            if (bear.gameObject.activeSelf) _activePet = "Bear";
            if (cat.gameObject.activeSelf) _activePet = "Cat";
            if (rabbit.gameObject.activeSelf) _activePet = "Rabbit";

            switch(_activePet)
            {
                case "Bear":
                    _operation = bear.happiness += stick.happinessLevel;
                    if(_operation >= 100)
                    {
                        bear.happiness = 100;
                        print("¡" + bear.petName + " ha jugado demasiado!");
                    }
                    else
                    {
                        print("Palo usado.");
                        print("Cantidad de felicidad de " + bear.petName +": " + bear.happiness);
                    }
                    selectStick = false;
                    break;

                case "Cat":
                    _operation = cat.happiness += stick.happinessLevel;
                    if(_operation >= 100)
                    {
                        cat.happiness = 100;
                        print("¡" + cat.petName + " ha jugado demaisado!");
                    }
                    else
                    {
                        print("Palo usado.");
                        print("Cantidad de felicidad de " + cat.petName + ": " +  cat.happiness);
                    }
                    selectStick = false;
                    break;
                case "Rabbit":
                    _operation = rabbit.happiness += stick.happinessLevel;
                    if(_operation >= 100)
                    {
                        rabbit.happiness = 100;
                        print("¡" + rabbit.petName + " ha jugado demasiado!");
                    }
                    else
                    {
                        print("Palo usado.");
                        print("Cantidad de felicidad de " + rabbit.petName + ": " + rabbit.happiness);
                    }
                    selectStick = false;
                    break;
                default:
                    {
                        print("Algo falla...");
                        selectStick = false;
                        break;
                    }
            }
        }
    }
        
}
    
