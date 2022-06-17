using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : IPlayerController
{
    public float HorizontalAxis => Input.GetAxis("Horizontal") * Time.deltaTime;
    public float VerticalAxis => Input.GetAxis("Vertical") * Time.deltaTime;
    public float HorizontalAxis2 => Input.GetAxis("Horizontal2") * Time.deltaTime;
    public float VerticalAxis2 => Input.GetAxis("Vertical2") * Time.deltaTime;


    public void Horizontal(Transform _transform, float _hSpeed)
    {
        _transform.position += new Vector3(HorizontalAxis * _hSpeed, 0);
    }

    public void Horizontal2(Transform _transform, float _hSpeed)
    {
        _transform.position += new Vector3(HorizontalAxis2 * _hSpeed, 0);
    }

    public void Vertical(Transform _transform, float _hSpeed)
    {
        _transform.position += new Vector3(0,0, VerticalAxis * _hSpeed);
    }
    public void Vertical2(Transform _transform, float _hSpeed)
    {
        _transform.position += new Vector3(0, 0, VerticalAxis2 * _hSpeed);
    }
    public void Rotate(Transform _transform, float _rotateSpeed)
    {
        Vector3 movement = new Vector3(HorizontalAxis, 0, VerticalAxis);
        Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);

        _transform.rotation = Quaternion.RotateTowards(_transform.rotation, toRotation, _rotateSpeed * Time.deltaTime);
    }
    public void Rotate2(Transform _transform, float _rotateSpeed)
    {
        Vector3 movement = new Vector3(HorizontalAxis2, 0, VerticalAxis2);
        Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);

        _transform.rotation = Quaternion.RotateTowards(_transform.rotation, toRotation, _rotateSpeed * Time.deltaTime);
    }












}

