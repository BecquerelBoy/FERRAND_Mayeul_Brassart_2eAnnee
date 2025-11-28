using UnityEngine;

public class VariablesFunctionsExercise : MonoBehaviour
{
    void Start()
    {
        // 1.a. variable tata et toto
        int tata = 5;
        int toto = 7;
        Debug.Log("Avant inversion : tata = " + tata + ", toto = " + toto);
        
        // Inversion de tata et toto
        (tata, toto) = (toto, tata);
        Debug.Log("Après inversion : tata = " + tata + ", toto = " + toto);
        
        // 1.b. Variable entière et flottante
        int titi = 2;
        float tutu = 6.34f;
        Debug.Log("Avant inversion : titi = " + titi + ", tutu = " + tutu);
        
        // Inversion en une seule ligne
        (titi, tutu) = ((int)tutu, titi);
        Debug.Log("Après inversion : titi = " + titi + ", tutu = " + tutu);
        
        // 2. Conversion entier en char
        int nombre = 65;
        char caractere = (char)nombre;
        Debug.Log("Entier " + nombre + " converti en char : " + caractere);
        
        // 3. Fonction Add() avec surcharge
        int sommeInt = Add(10, 20);
        float sommeFloat = Add(3.5f, 2.8f);
        Debug.Log("Somme entiers : " + sommeInt);
        Debug.Log("Somme flottants : " + sommeFloat);
        
        // 4. Fonction Multiply avec paramètre out
        int resultatMultiply;
        Multiply(6, 7, out resultatMultiply);
        Debug.Log("Résultat de la multiplication : " + resultatMultiply);
        
        // 5. Fonction IsMajor
        IsMajor(15);
        IsMajor(18);
        IsMajor(25);
    }
    
    // 3.a. Addition de deux entiers
    int Add(int a, int b)
    {
        return a + b;
    }
    
    // 3.b. Addition de deux flottants (surcharge)
    float Add(float a, float b)
    {
        return a + b;
    }
    
    // 4. Multiplication avec paramètre out
    void Multiply(int a, int b, out int result)
    {
        result = a * b;
    }
    
    // 5. Vérification de majorité
    void IsMajor(int age)
    {
        Debug.Log("Est majeur : " + (age >= 18));
    }
}