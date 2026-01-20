using UnityEngine;
using UnityEngine.InputSystem;

public class squaretest : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //pickARandomColor(); 


        // Update is called once per frame
        void Update()
        {
            //if (Keyboard.current.anyKey.wasPressedThisFrame == true)
            //{
            //    //pickARandomColor();
            //}
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadDefaultValue());
            // get the mouse posistion 
            //is it over the shape?
            if (spriteRenderer.bounds.Contains(mousePos) == true)

            {
                // y: set the color with our col variable
                spriteRenderer.color = col;
            }
            else
            {

                //N: set the color to white
                spriteRenderer.color = Color.white;
            }
        }

        void pickARandomColor()

        {
            spriteRenderer.color = Random.ColorHSV();

        }
    }
}