using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics : MonoBehaviour {

    int player = 1;
    string participant;
    bool x; 
    bool y;
    
	// Use this for initialization
	void Start () 
    {
        //variablen deklariert
    
        bool muede;
        float score;
        char category;
        byte none;
        long none1;
        short none2;
        double none3;
        
        addOne();
        int test = getNumber();
        Debug.Log(test);
        Debug.Log("--------------------------------");
        Debug.Log(getNumber());
        setName();
        testbool();
        division();
        multiplikation();
        modulo();
        kleiner();
        groeßer();
        kleinergleich();
        groeßergleich();
	}
    void division()
    {
        float a;
        a = 16;
        float b;
        b = 3;
        Debug.Log(a/b);
    }
    
     void multiplikation()
    {
        int a = 18;
        int b = 5;
        Debug.Log(a*b);
    }
    
      void modulo()
    {
        int a = 275;
        int b = 145;
        Debug.Log(a%b);
    }
    
        void kleiner()
    {
        int a = 187;
        int b = 90;
        Debug.Log(a<b);
    }
        void groeßer()
    {
        int a = 187;
        int b = 90;
        Debug.Log(a>b);
    }
        void kleinergleich()
    {
        int a = 187;
        int b = 90;
        Debug.Log(a<=b);
    }
        void groeßergleich()
    {
        int a = 187;
        int b = 90;
        Debug.Log(a>=b);
    }
    
    
    
    void testbool()
    {
        x = true;
        y = true;
        
        Debug.Log("W oder F" + (x&y));
        Debug.Log("Bedingt W oder F" + (x && y));
    }
    
    void setName()
    {
        participant = "max mu$termann";
        Debug.Log(participant);
        
    }
    
    void addOne ()
    {
        player = player + 1;
        Debug.Log("player = "+ player);
        
    }
    
    int getNumber()
    {
        return 5;   
    }
	
	// Update is called once per frame
	void Update () 
    {
		
	}
}
