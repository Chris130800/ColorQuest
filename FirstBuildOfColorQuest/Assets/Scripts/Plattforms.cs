using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plattforms : MonoBehaviour {

    public GameObject platform;

	// Use this for initialization
	void Start () {
        /*FirstPlatform();
        SecondPlatform();
        ThirdPlatform();
        FourthPlatform();
        FifthPlatform();*/
        CreatePlatform(-7,-3,37,6);
        CreatePlatform(-2, -3, 35, 6);
        CreatePlatform(4, 3, 37, 6);
        CreatePlatform(-4, -1, 25, 6);
        CreatePlatform(1, -1, 25, 6);
	}

    public void CreatePlatform( float posX, float posY, int width, int height)
    {
        float startposX = posX;
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                GameObject pen = Instantiate(platform);
                pen.GetComponent<Transform>().transform.position = new Vector2((float)posX, (float)posY);
                posX += 0.1f;
            }
            posX = startposX;
            posY -= 0.1f;
        }
        
    }

    /*void FirstPlatform()
    {
        double posX = -7;
        double posY = -3.3;

        for (int y = 0; y < 6; y++)
        {
            for (int x = 0; x < 37; x++)
            {
                GameObject pen = Instantiate(platform);
                pen.GetComponent<Transform>().transform.position = new Vector2((float)posX, (float)posY);
                posX += 0.1;
            }
            posX = -7;
            posY -= 0.1;
        }
    }

    void SecondPlatform()
    {
        double posX = -1.8;
        double posY = -3.3;

        for (int y = 0; y < 6; y++)
        {
            for (int x = 0; x < 35; x++)
            {
                GameObject pen = Instantiate(platform);
                pen.GetComponent<Transform>().transform.position = new Vector2((float)posX, (float)posY);
                posX += 0.1;
            }
            posX = -1.8;
            posY -= 0.1;
        }
    }

    void ThirdPlatform()
    {
        double posX = 3.5;
        double posY = -3.3;

        for (int y = 0; y < 6; y++)
        {
            for (int x = 0; x < 37; x++)
            {
                GameObject pen = Instantiate(platform);
                pen.GetComponent<Transform>().transform.position = new Vector2((float)posX, (float)posY);
                posX += 0.1;
            }
            posX = 3.5;
            posY -= 0.1;
        }
    }

    void FourthPlatform()
    {
        double posX = -3.5;
        double posY = -0.7;

        for (int y = 0; y < 6; y++)
        {
            for (int x = 0; x < 25; x++)
            {
                GameObject pen = Instantiate(platform);
                pen.GetComponent<Transform>().transform.position = new Vector2((float)posX, (float)posY);
                posX += 0.1;
            }
            posX = -3.5;
            posY -= 0.1;
        }
    }

    void FifthPlatform()
    {
        double posX = 0.9;
        double posY = -0.7;

        for (int y = 0; y < 6; y++)
        {
            for (int x = 0; x < 25; x++)
            {
                GameObject pen = Instantiate(platform);
                pen.GetComponent<Transform>().transform.position = new Vector2((float)posX, (float)posY);
                posX += 0.1;
            }
            posX = 0.9;
            posY -= 0.1;
        }
    }*/
	
}
