using UnityEngine;
public class mouceUtis
{

    public static Vector2 GetMoucePosition2d()

    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }







}
