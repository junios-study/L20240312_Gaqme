
class PlayerController : Component
{
    public override void Update()
    {
        int oldX = transform.x;
        int oldY = transform.y;

        if (Input.GetButton("Left"))
        {
            transform.Translate(-1, 0);
        }
        if (Input.GetButton("Right"))
        {
            transform.Translate(1, 0);
        }
        if (Input.GetButton("Up"))
        {
            transform.Translate(0, -1);
        }
        if (Input.GetButton("Down"))
        {
            transform.Translate(0, +1);
        }
        if (Input.GetButton("Quit"))
        {
            //singleton pattern
            Engine.GetInstance().Stop();
        }

        transform.x = Math.Clamp(transform.x, 0, 80);
        transform.y = Math.Clamp(transform.y, 0, 80);


        //Collider2D 컴포넌트를 가지는 모든 게임 오브젝트를 찾는다.
        //자기 자신은 제외
        //Player와 충돌 하는 체크
        foreach (GameObject findGameObject in Engine.GetInstance().gameObjects)
        {
            if (findGameObject == gameObject)
            {
                //자신 오브젝트 제외
                continue;
            }

            Collider2D? findComponent = findGameObject.GetComponent<Collider2D>();
            if (findComponent != null)
            {
                if(findComponent.Check(gameObject) && findComponent.isTrigger == false)
                {
                    //충돌
                    transform.x = oldX;
                    transform.y = oldY;
                    break;
                }
            }
        }
    }
}

