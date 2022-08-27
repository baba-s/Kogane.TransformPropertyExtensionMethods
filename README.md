# Kogane Transform Property Extension Methods

GameObject 型や Component 型から Transform の Position、Rotation、Scale を操作できるようにする拡張メソッド

## GameObject

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        // transform.position を操作
        gameObject.ResetPosition();
        gameObject.SetPositionX( 1 );
        gameObject.SetPositionY( 2 );
        gameObject.SetPositionZ( 3 );
        gameObject.SetPosition( 1, 2 );
        gameObject.SetPosition( 1, 2, 3 );
        gameObject.SetPosition( new Vector2( 1, 2 ) );
        gameObject.SetPosition( new Vector3( 1, 2, 3 ) );
        gameObject.AddPositionX( 1 );
        gameObject.AddPositionY( 2 );
        gameObject.AddPositionZ( 3 );
        gameObject.AddPosition( 1, 2 );
        gameObject.AddPosition( 1, 2, 3 );
        gameObject.AddPosition( new Vector2( 1, 2 ) );
        gameObject.AddPosition( new Vector3( 1, 2, 3 ) );

        // transform.localPosition を操作
        gameObject.ResetLocalPosition();
        gameObject.SetLocalPositionX( 1 );
        gameObject.SetLocalPositionY( 2 );
        gameObject.SetLocalPositionZ( 3 );
        gameObject.SetLocalPosition( 1, 2 );
        gameObject.SetLocalPosition( 1, 2, 3 );
        gameObject.SetLocalPosition( new Vector2( 1, 2 ) );
        gameObject.SetLocalPosition( new Vector3( 1, 2, 3 ) );
        gameObject.AddLocalPositionX( 1 );
        gameObject.AddLocalPositionY( 2 );
        gameObject.AddLocalPositionZ( 3 );
        gameObject.AddLocalPosition( 1, 2 );
        gameObject.AddLocalPosition( 1, 2, 3 );
        gameObject.AddLocalPosition( new Vector2( 1, 2 ) );
        gameObject.AddLocalPosition( new Vector3( 1, 2, 3 ) );

        // transform.localScale を操作
        gameObject.ResetLocalScale();
        gameObject.SetLocalScaleX( 1 );
        gameObject.SetLocalScaleY( 2 );
        gameObject.SetLocalScaleZ( 3 );
        gameObject.SetLocalScale( 1, 2 );
        gameObject.SetLocalScale( 1, 2, 3 );
        gameObject.SetLocalScale( new Vector2( 1, 2 ) );
        gameObject.SetLocalScale( new Vector3( 1, 2, 3 ) );
        gameObject.AddLocalScaleX( 1 );
        gameObject.AddLocalScaleY( 2 );
        gameObject.AddLocalScaleZ( 3 );
        gameObject.AddLocalScale( 1, 2 );
        gameObject.AddLocalScale( 1, 2, 3 );
        gameObject.AddLocalScale( new Vector2( 1, 2 ) );
        gameObject.AddLocalScale( new Vector3( 1, 2, 3 ) );

        // transform.eulerAngles を操作
        gameObject.ResetEulerAngles();
        gameObject.SetEulerAngleX( 1 );
        gameObject.SetEulerAngleY( 2 );
        gameObject.SetEulerAngleZ( 3 );
        gameObject.SetEulerAngles( 1, 2, 3 );
        gameObject.SetEulerAngles( new Vector2( 1, 2 ) );
        gameObject.SetEulerAngles( new Vector3( 1, 2, 3 ) );
        gameObject.AddEulerAngleX( 1 );
        gameObject.AddEulerAngleY( 2 );
        gameObject.AddEulerAngleZ( 3 );

        // transform.localEulerAngles を操作
        gameObject.ResetLocalEulerAngles();
        gameObject.SetLocalEulerAngleX( 1 );
        gameObject.SetLocalEulerAngleY( 2 );
        gameObject.SetLocalEulerAngleZ( 3 );
        gameObject.SetLocalEulerAngles( 1, 2, 3 );
        gameObject.SetLocalEulerAngles( new Vector2( 1, 2 ) );
        gameObject.SetLocalEulerAngles( new Vector3( 1, 2, 3 ) );
        gameObject.AddLocalEulerAngleX( 1 );
        gameObject.AddLocalEulerAngleY( 2 );
        gameObject.AddLocalEulerAngleZ( 3 );
    }
}
```

## Component

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        // transform.position を操作
        this.ResetPosition();
        this.SetPositionX( 1 );
        this.SetPositionY( 2 );
        this.SetPositionZ( 3 );
        this.SetPosition( 1, 2 );
        this.SetPosition( 1, 2, 3 );
        this.SetPosition( new Vector2( 1, 2 ) );
        this.SetPosition( new Vector3( 1, 2, 3 ) );
        this.AddPositionX( 1 );
        this.AddPositionY( 2 );
        this.AddPositionZ( 3 );
        this.AddPosition( 1, 2 );
        this.AddPosition( 1, 2, 3 );
        this.AddPosition( new Vector2( 1, 2 ) );
        this.AddPosition( new Vector3( 1, 2, 3 ) );

        // transform.localPosition を操作
        this.ResetLocalPosition();
        this.SetLocalPositionX( 1 );
        this.SetLocalPositionY( 2 );
        this.SetLocalPositionZ( 3 );
        this.SetLocalPosition( 1, 2 );
        this.SetLocalPosition( 1, 2, 3 );
        this.SetLocalPosition( new Vector2( 1, 2 ) );
        this.SetLocalPosition( new Vector3( 1, 2, 3 ) );
        this.AddLocalPositionX( 1 );
        this.AddLocalPositionY( 2 );
        this.AddLocalPositionZ( 3 );
        this.AddLocalPosition( 1, 2 );
        this.AddLocalPosition( 1, 2, 3 );
        this.AddLocalPosition( new Vector2( 1, 2 ) );
        this.AddLocalPosition( new Vector3( 1, 2, 3 ) );

        // transform.localScale を操作
        this.ResetLocalScale();
        this.SetLocalScaleX( 1 );
        this.SetLocalScaleY( 2 );
        this.SetLocalScaleZ( 3 );
        this.SetLocalScale( 1, 2 );
        this.SetLocalScale( 1, 2, 3 );
        this.SetLocalScale( new Vector2( 1, 2 ) );
        this.SetLocalScale( new Vector3( 1, 2, 3 ) );
        this.AddLocalScaleX( 1 );
        this.AddLocalScaleY( 2 );
        this.AddLocalScaleZ( 3 );
        this.AddLocalScale( 1, 2 );
        this.AddLocalScale( 1, 2, 3 );
        this.AddLocalScale( new Vector2( 1, 2 ) );
        this.AddLocalScale( new Vector3( 1, 2, 3 ) );

        // transform.eulerAngles を操作
        this.ResetEulerAngles();
        this.SetEulerAngleX( 1 );
        this.SetEulerAngleY( 2 );
        this.SetEulerAngleZ( 3 );
        this.SetEulerAngles( 1, 2, 3 );
        this.SetEulerAngles( new Vector2( 1, 2 ) );
        this.SetEulerAngles( new Vector3( 1, 2, 3 ) );
        this.AddEulerAngleX( 1 );
        this.AddEulerAngleY( 2 );
        this.AddEulerAngleZ( 3 );

        // transform.localEulerAngles を操作
        this.ResetLocalEulerAngles();
        this.SetLocalEulerAngleX( 1 );
        this.SetLocalEulerAngleY( 2 );
        this.SetLocalEulerAngleZ( 3 );
        this.SetLocalEulerAngles( 1, 2, 3 );
        this.SetLocalEulerAngles( new Vector2( 1, 2 ) );
        this.SetLocalEulerAngles( new Vector3( 1, 2, 3 ) );
        this.AddLocalEulerAngleX( 1 );
        this.AddLocalEulerAngleY( 2 );
        this.AddLocalEulerAngleZ( 3 );
    }
}
```
