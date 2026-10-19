using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
     [SerializeField, Range(1, 10)] float m_speed = 5.0f;
     InputSystem_Actions m_actions;
     InputSystem_Actions.PlayerActions m_player;

     private void Awake()
     {
         m_actions = new InputSystem_Actions();
         m_player = m_actions.Player;
     }

     private void OnEnable() => m_actions.Enable();
     private void OnDisable() => m_actions.Disable();
     private void OnDestroy() => m_actions.Dispose();

     // Update is called once per frame
     void Update()
     {
         Vector2 moveInp = m_player.Move.ReadValue<Vector2>();
         transform.Translate(moveInp * m_speed * Time.deltaTime, Space.World);

         // x座標を -2 から 2 の間に強制的に制限する
         Vector3 clampedPosition = transform.position;
         clampedPosition.x = Mathf.Clamp(clampedPosition.x, -2.0f, 2.0f);
         transform.position = clampedPosition;

         if (moveInp != Vector2.zero)
         {
             Debug.Log("Move Vector: " + moveInp.ToString());
         }
     }
}