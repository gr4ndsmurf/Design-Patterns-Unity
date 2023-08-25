using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public SquareFactory squareFactory;
    public TriangleFactory triangleFactory;
    public CircleFactory circleFactory;

    public TextMeshProUGUI txtObject;

    private Vector3 deliveryPosition;

    enum ObjectToProduce { Square1, Square2, Square3, Triangle1, Triangle2, Circle1}
    ObjectToProduce _object = ObjectToProduce.Square1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            SetDeliverySlot(0);
            ProduceNow();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetDeliverySlot(1);
            ProduceNow();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetDeliverySlot(2);
            ProduceNow();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetDeliverySlot(3);
            ProduceNow();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SetDeliverySlot(4);
            ProduceNow();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SetDeliverySlot(5);
            ProduceNow();
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SetDeliverySlot(6);
            ProduceNow();
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            SetDeliverySlot(7);
            ProduceNow();
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            SetDeliverySlot(8);
            ProduceNow();
        }
    }

    // For Alpha Keys to set delivey pos.
    public void SetDeliverySlot(int slot)
    {
        switch (slot)
        {
            case 1:
                deliveryPosition = new Vector3(1.15f, 1.15f, 0f);
                break;
            case 2:
                deliveryPosition = new Vector3(3.15f, 1.15f, 0f);
                break;
            case 3:
                deliveryPosition = new Vector3(5.15f, 1.15f, 0f);
                break;
            case 4:
                deliveryPosition = new Vector3(7.1f, 1.15f, 0f);
                break;
            case 5:
                deliveryPosition = new Vector3(1.15f, -2.87f, 0f);
                break;
            case 6:
                deliveryPosition = new Vector3(3.15f, -2.87f, 0f);
                break;
            case 7:
                deliveryPosition = new Vector3(5.15f, -2.87f, 0f);
                break;
            case 8:
                deliveryPosition = new Vector3(7.1f, -2.87f, 0f);
                break;
            default:
                deliveryPosition = new Vector3(1.15f, 1.15f, 0f);
                break;
        }
    }

    // For UI Button to decide what to produce.
    public void DecideWhatToProduce(int what)
    {
        switch (what)
        {
            case 0:
                _object = ObjectToProduce.Square1;
                txtObject.text = "Square 1";
                break;
            case 1:
                _object = ObjectToProduce.Square2;
                txtObject.text = "Square 2";
                break;
            case 2:
                _object = ObjectToProduce.Square3;
                txtObject.text = "Square 3";
                break;
            case 3:
                _object = ObjectToProduce.Triangle1;
                txtObject.text = "Triangle 1";
                break;
            case 4:
                _object = ObjectToProduce.Triangle2;
                txtObject.text = "Triangle 2";
                break;
            case 5:
                _object = ObjectToProduce.Circle1;
                txtObject.text = "Circle 1";
                break;
        }
    }

    // Producing the decided object after clicking the UI Button.
    public void ProduceNow()
    {
        switch (_object)
        {
            case ObjectToProduce.Square1:
                squareFactory.GetProduct(SquareFactory.SQUARE_TYPE_1, deliveryPosition);
                break;
            case ObjectToProduce.Square2:
                squareFactory.GetProduct(SquareFactory.SQUARE_TYPE_2, deliveryPosition);
                break;
            case ObjectToProduce.Square3:
                squareFactory.GetProduct(SquareFactory.SQUARE_TYPE_3, deliveryPosition);
                break;
            case ObjectToProduce.Triangle1:
                triangleFactory.GetProduct(TriangleFactory.TRIANGLE_TYPE_1, deliveryPosition);
                break;
            case ObjectToProduce.Triangle2:
                triangleFactory.GetProduct(TriangleFactory.TRIANGLE_TYPE_2, deliveryPosition);
                break;
            case ObjectToProduce.Circle1:
                circleFactory.GetProduct(CircleFactory.CIRCLE_TYPE_1, deliveryPosition);
                break;
        }
    }
}
