using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// Component 型の拡張メソッドを管理するクラス
    /// </summary>
    public static class ComponentExtensionMethods
    {
        //================================================================================
        // 取得
        //================================================================================
        public static Vector3 GetPosition( this       Component self ) => self.transform.position;
        public static float   GetPositionX( this      Component self ) => self.transform.position.x;
        public static float   GetPositionY( this      Component self ) => self.transform.position.y;
        public static float   GetPositionZ( this      Component self ) => self.transform.position.z;
        public static Vector3 GetLocalPosition( this  Component self ) => self.transform.localPosition;
        public static float   GetLocalPositionX( this Component self ) => self.transform.localPosition.x;
        public static float   GetLocalPositionY( this Component self ) => self.transform.localPosition.y;
        public static float   GetLocalPositionZ( this Component self ) => self.transform.localPosition.z;

        public static Vector3 GetEulerAngles( this       Component self ) => self.transform.eulerAngles;
        public static float   GetEulerAnglesX( this      Component self ) => self.transform.eulerAngles.x;
        public static float   GetEulerAnglesY( this      Component self ) => self.transform.eulerAngles.y;
        public static float   GetEulerAnglesZ( this      Component self ) => self.transform.eulerAngles.z;
        public static Vector3 GetLocalEulerAngles( this  Component self ) => self.transform.localEulerAngles;
        public static float   GetLocalEulerAnglesX( this Component self ) => self.transform.localEulerAngles.x;
        public static float   GetLocalEulerAnglesY( this Component self ) => self.transform.localEulerAngles.y;
        public static float   GetLocalEulerAnglesZ( this Component self ) => self.transform.localEulerAngles.z;

        public static Vector3 GetLocalScale( this  Component self ) => self.transform.localScale;
        public static float   GetLocalScaleX( this Component self ) => self.transform.localScale.x;
        public static float   GetLocalScaleY( this Component self ) => self.transform.localScale.y;
        public static float   GetLocalScaleZ( this Component self ) => self.transform.localScale.z;

        //================================================================================
        // ワールド座標における位置
        //================================================================================
        /// <summary>
        /// ワールド座標における位置をリセットします
        /// </summary>
        public static void ResetPosition( this Component self )
        {
            self.transform.position = Vector3.zero;
        }

        /// <summary>
        /// ワールド座標における X 座標を設定します
        /// </summary>
        public static void SetPositionX( this Component self, float x )
        {
            var transform = self.transform;
            var pos       = transform.position;
            pos = new
            (
                x,
                pos.y,
                pos.z
            );
            transform.position = pos;
        }

        /// <summary>
        /// ワールド座標における Y 座標を設定します
        /// </summary>
        public static void SetPositionY( this Component self, float y )
        {
            var transform = self.transform;
            var pos       = transform.position;
            pos = new
            (
                pos.x,
                y,
                pos.z
            );
            transform.position = pos;
        }

        /// <summary>
        /// ワールド座標における Z 座標を設定します
        /// </summary>
        public static void SetPositionZ( this Component self, float z )
        {
            var transform = self.transform;
            var pos       = transform.position;
            pos = new
            (
                pos.x,
                pos.y,
                z
            );
            transform.position = pos;
        }

        /// <summary>
        /// Vector2 型でワールド座標における位置を設定します
        /// </summary>
        public static void SetPosition( this Component self, Vector2 v )
        {
            var transform = self.transform;
            transform.position = new
            (
                v.x,
                v.y,
                transform.position.z
            );
        }

        /// <summary>
        /// Vector3 型でワールド座標における位置を設定します
        /// </summary>
        public static void SetPosition( this Component self, Vector3 v )
        {
            self.transform.position = v;
        }

        /// <summary>
        /// ワールド座標における位置を設定します
        /// </summary>
        public static void SetPosition
        (
            this Component self,
            float          x,
            float          y
        )
        {
            var transform = self.transform;
            transform.position = new
            (
                x,
                y,
                transform.position.z
            );
        }

        /// <summary>
        /// ワールド座標における位置を設定します
        /// </summary>
        public static void SetPosition
        (
            this Component self,
            float          x,
            float          y,
            float          z
        )
        {
            self.transform.position = new
            (
                x,
                y,
                z
            );
        }

        /// <summary>
        /// ワールド座標における X 座標に加算します
        /// </summary>
        public static void AddPositionX( this Component self, float x )
        {
            var transform = self.transform;
            var pos       = transform.position;
            pos = new
            (
                pos.x + x,
                pos.y,
                pos.z
            );
            transform.position = pos;
        }

        /// <summary>
        /// ワールド座標における Y 座標に加算します
        /// </summary>
        public static void AddPositionY( this Component self, float y )
        {
            var transform = self.transform;
            var pos       = transform.position;
            pos = new
            (
                pos.x,
                pos.y + y,
                pos.z
            );
            transform.position = pos;
        }

        /// <summary>
        /// ワールド座標における Z 座標に加算します
        /// </summary>
        public static void AddPositionZ( this Component self, float z )
        {
            var transform = self.transform;
            var pos       = transform.position;
            pos = new
            (
                pos.x,
                pos.y,
                pos.z + z
            );
            transform.position = pos;
        }

        /// <summary>
        /// Vector2 型でワールド座標における位置を加算します
        /// </summary>
        public static void AddPosition( this Component self, Vector2 v )
        {
            var transform = self.transform;
            var pos       = transform.position;
            pos = new
            (
                pos.x + v.x,
                pos.y + v.y,
                pos.z
            );
            transform.position = pos;
        }

        /// <summary>
        /// Vector3 型でワールド座標における位置を加算します
        /// </summary>
        public static void AddPosition( this Component self, Vector3 v )
        {
            self.transform.position += v;
        }

        /// <summary>
        /// ワールド座標における位置を加算します
        /// </summary>
        public static void AddPosition
        (
            this Component self,
            float          x,
            float          y
        )
        {
            var transform = self.transform;
            var pos       = transform.position;
            pos = new
            (
                pos.x + x,
                pos.y + y,
                pos.z
            );
            transform.position = pos;
        }

        /// <summary>
        /// ワールド座標における位置を加算します
        /// </summary>
        public static void AddPosition
        (
            this Component self,
            float          x,
            float          y,
            float          z
        )
        {
            var transform = self.transform;
            var pos       = transform.position;
            pos = new
            (
                pos.x + x,
                pos.y + y,
                pos.z + z
            );
            transform.position = pos;
        }

        //================================================================================
        // ローカル座標における位置
        //================================================================================
        /// <summary>
        /// ローカル座標における位置をリセットします
        /// </summary>
        public static void ResetLocalPosition( this Component self )
        {
            self.transform.localPosition = Vector3.zero;
        }

        /// <summary>
        /// ローカル座標における X 座標を設定します
        /// </summary>
        public static void SetLocalPositionX( this Component self, float x )
        {
            var transform = self.transform;
            var pos       = transform.localPosition;
            pos = new
            (
                x,
                pos.y,
                pos.z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// ローカル座標における Y 座標を設定します
        /// </summary>
        public static void SetLocalPositionY( this Component self, float y )
        {
            var transform = self.transform;
            var pos       = transform.localPosition;
            pos = new
            (
                pos.x,
                y,
                pos.z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// ローカル座標における Z 座標を設定します
        /// </summary>
        public static void SetLocalPositionZ( this Component self, float z )
        {
            var transform = self.transform;
            var pos       = transform.localPosition;
            pos = new
            (
                pos.x,
                pos.y,
                z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// Vector2 型でローカル座標における位置を設定します
        /// </summary>
        public static void SetLocalPosition( this Component self, Vector2 v )
        {
            var transform = self.transform;
            transform.localPosition = new
            (
                v.x,
                v.y,
                transform.localPosition.z
            );
        }

        /// <summary>
        /// Vector3 型でローカル座標における位置を設定します
        /// </summary>
        public static void SetLocalPosition( this Component self, Vector3 v )
        {
            self.transform.localPosition = v;
        }

        /// <summary>
        /// ローカル座標における位置を設定します
        /// </summary>
        public static void SetLocalPosition
        (
            this Component self,
            float          x,
            float          y
        )
        {
            var transform = self.transform;
            transform.localPosition = new
            (
                x,
                y,
                transform.localPosition.z
            );
        }

        /// <summary>
        /// ローカル座標における位置を設定します
        /// </summary>
        public static void SetLocalPosition
        (
            this Component self,
            float          x,
            float          y,
            float          z
        )
        {
            self.transform.localPosition = new
            (
                x,
                y,
                z
            );
        }

        /// <summary>
        /// ローカル座標における X 座標に加算します
        /// </summary>
        public static void AddLocalPositionX( this Component self, float x )
        {
            var transform = self.transform;
            var pos       = transform.localPosition;
            pos = new
            (
                pos.x + x,
                pos.y,
                pos.z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// ローカル座標における Y 座標に加算します
        /// </summary>
        public static void AddLocalPositionY( this Component self, float y )
        {
            var transform = self.transform;
            var pos       = transform.localPosition;
            pos = new
            (
                pos.x,
                pos.y + y,
                pos.z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// ローカル座標における Z 座標に加算します
        /// </summary>
        public static void AddLocalPositionZ( this Component self, float z )
        {
            var transform = self.transform;
            var pos       = transform.localPosition;
            pos = new
            (
                pos.x,
                pos.y,
                pos.z + z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// Vector2 型でローカル座標における位置を加算します
        /// </summary>
        public static void AddLocalPosition( this Component self, Vector2 v )
        {
            var transform = self.transform;
            var pos       = transform.localPosition;
            pos = new
            (
                pos.x + v.x,
                pos.y + v.y,
                pos.z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// Vector3 型でローカル座標における位置を加算します
        /// </summary>
        public static void AddLocalPosition( this Component self, Vector3 v )
        {
            self.transform.localPosition += v;
        }

        /// <summary>
        /// ローカル座標における位置を加算します
        /// </summary>
        public static void AddLocalPosition
        (
            this Component self,
            float          x,
            float          y
        )
        {
            var transform = self.transform;
            var pos       = transform.localPosition;
            pos = new
            (
                pos.x + x,
                pos.y + y,
                pos.z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// ローカル座標における位置を加算します
        /// </summary>
        public static void AddLocalPosition
        (
            this Component self,
            float          x,
            float          y,
            float          z
        )
        {
            var transform = self.transform;
            var pos       = transform.localPosition;
            pos = new
            (
                pos.x + x,
                pos.y + y,
                pos.z + z
            );
            transform.localPosition = pos;
        }

        //================================================================================
        // ワールド座標における回転角
        //================================================================================
        /// <summary>
        /// ワールド座標における回転角をリセットします
        /// </summary>
        public static void ResetEulerAngles( this Component self )
        {
            self.transform.eulerAngles = Vector3.zero;
        }

        /// <summary>
        /// ワールド座標における X 軸方向の回転角を設定します
        /// </summary>
        public static void SetEulerAngleX( this Component self, float x )
        {
            var transform = self.transform;
            var angles    = transform.eulerAngles;
            angles = new
            (
                x,
                angles.y,
                angles.z
            );
            transform.eulerAngles = angles;
        }

        /// <summary>
        /// ワールド座標における Y 軸方向の回転角を設定します
        /// </summary>
        public static void SetEulerAngleY( this Component self, float y )
        {
            var transform = self.transform;
            var angles    = transform.eulerAngles;
            angles = new
            (
                angles.x,
                y,
                angles.z
            );
            transform.eulerAngles = angles;
        }

        /// <summary>
        /// ワールド座標における Z 軸方向の回転角を設定します
        /// </summary>
        public static void SetEulerAngleZ( this Component self, float z )
        {
            var transform = self.transform;
            var angles    = transform.eulerAngles;
            angles = new
            (
                angles.x,
                angles.y,
                z
            );
            transform.eulerAngles = angles;
        }

        /// <summary>
        /// ワールド座標における回転角を設定します
        /// </summary>
        public static void SetEulerAngles( this Component self, Vector3 v )
        {
            self.transform.eulerAngles = v;
        }

        /// <summary>
        /// ワールド座標における回転角を設定します
        /// </summary>
        public static void SetEulerAngles
        (
            this Component self,
            float          x,
            float          y,
            float          z
        )
        {
            self.transform.eulerAngles = new
            (
                x,
                y,
                z
            );
        }

        /// <summary>
        /// ワールド座標における X 軸方向の回転角を加算します
        /// </summary>
        public static void AddEulerAngleX( this Component self, float x )
        {
            self.transform.Rotate( x, 0, 0, Space.World );
        }

        /// <summary>
        /// ワールド座標における Y 軸方向の回転角を加算します
        /// </summary>
        public static void AddEulerAngleY( this Component self, float y )
        {
            self.transform.Rotate( 0, y, 0, Space.World );
        }

        /// <summary>
        /// ワールド座標における Z 軸方向の回転角を加算します
        /// </summary>
        public static void AddEulerAngleZ( this Component self, float z )
        {
            self.transform.Rotate( 0, 0, z, Space.World );
        }

        //================================================================================
        // ローカル座標における回転角
        //================================================================================
        /// <summary>
        /// ローカル座標における回転角をリセットします
        /// </summary>
        public static void ResetLocalEulerAngles( this Component self )
        {
            self.transform.localEulerAngles = Vector3.zero;
        }

        /// <summary>
        /// ローカル座標における X 軸方向の回転角を設定します
        /// </summary>
        public static void SetLocalEulerAngleX( this Component self, float x )
        {
            var transform = self.transform;
            var angles    = transform.localEulerAngles;
            angles = new
            (
                x,
                angles.y,
                angles.z
            );
            transform.localEulerAngles = angles;
        }

        /// <summary>
        /// ローカル座標における Y 軸方向の回転角を設定します
        /// </summary>
        public static void SetLocalEulerAngleY( this Component self, float y )
        {
            var transform = self.transform;
            var angles    = transform.localEulerAngles;
            angles = new
            (
                angles.x,
                y,
                angles.z
            );
            transform.localEulerAngles = angles;
        }

        /// <summary>
        /// ローカル座標における Z 軸方向の回転角を設定します
        /// </summary>
        public static void SetLocalEulerAngleZ( this Component self, float z )
        {
            var transform = self.transform;
            var angles    = transform.localEulerAngles;
            angles = new
            (
                angles.x,
                angles.y,
                z
            );
            transform.localEulerAngles = angles;
        }

        /// <summary>
        /// ローカル座標における回転角を設定します
        /// </summary>
        public static void SetLocalEulerAngles( this Component self, Vector3 v )
        {
            self.transform.localEulerAngles = v;
        }

        /// <summary>
        /// ローカル座標における回転角を設定します
        /// </summary>
        public static void SetLocalEulerAngles
        (
            this Component self,
            float          x,
            float          y,
            float          z
        )
        {
            self.transform.localEulerAngles = new
            (
                x,
                y,
                z
            );
        }

        /// <summary>
        /// ローカル座標における X 軸方向の回転角を加算します
        /// </summary>
        public static void AddLocalEulerAngleX( this Component self, float x )
        {
            self.transform.Rotate( x, 0, 0, Space.Self );
        }

        /// <summary>
        /// ローカル座標における Y 軸方向の回転角を加算します
        /// </summary>
        public static void AddLocalEulerAngleY( this Component self, float y )
        {
            self.transform.Rotate( 0, y, 0, Space.Self );
        }

        /// <summary>
        /// ローカル座標における X 軸方向の回転角を加算します
        /// </summary>
        public static void AddLocalEulerAngleZ( this Component self, float z )
        {
            self.transform.Rotate( 0, 0, z, Space.Self );
        }

        //================================================================================
        // ローカル座標におけるスケーリング値
        //================================================================================
        /// <summary>
        /// ローカル座標におけるスケーリング値をリセットします
        /// </summary>
        public static void ResetLocalScale( this Component self )
        {
            self.transform.localScale = Vector3.one;
        }

        /// <summary>
        /// ローカル座標における X 軸方向のスケーリング値を設定します
        /// </summary>
        public static void SetLocalScaleX( this Component self, float x )
        {
            var transform = self.transform;
            var scale     = transform.localScale;
            scale = new
            (
                x,
                scale.y,
                scale.z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// ローカル座標における Y 軸方向のスケーリング値を設定します
        /// </summary>
        public static void SetLocalScaleY( this Component self, float y )
        {
            var transform = self.transform;
            var scale     = transform.localScale;
            scale = new
            (
                scale.x,
                y,
                scale.z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// ローカル座標における Z 軸方向のスケーリング値を設定します
        /// </summary>
        public static void SetLocalScaleZ( this Component self, float z )
        {
            var transform = self.transform;
            var scale     = transform.localScale;
            scale = new
            (
                scale.x,
                scale.y,
                z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// Vector2 型でローカル座標におけるスケーリング値を設定します
        /// </summary>
        public static void SetLocalScale( this Component self, Vector2 v )
        {
            var transform = self.transform;
            transform.localScale = new
            (
                v.x,
                v.y,
                transform.localScale.z
            );
        }

        /// <summary>
        /// Vector3 型でローカル座標におけるスケーリング値を設定します
        /// </summary>
        public static void SetLocalScale( this Component self, Vector3 v )
        {
            self.transform.localScale = v;
        }

        /// <summary>
        /// ローカル座標におけるスケーリング値を設定します
        /// </summary>
        public static void SetLocalScale
        (
            this Component self,
            float          x,
            float          y
        )
        {
            var transform = self.transform;
            transform.localScale = new
            (
                x,
                y,
                transform.localScale.z
            );
        }

        /// <summary>
        /// ローカル座標におけるスケーリング値を設定します
        /// </summary>
        public static void SetLocalScale
        (
            this Component self,
            float          x,
            float          y,
            float          z
        )
        {
            self.transform.localScale = new
            (
                x,
                y,
                z
            );
        }

        /// <summary>
        /// ローカル座標における X 軸方向のスケーリング値を加算します
        /// </summary>
        public static void AddLocalScaleX( this Component self, float x )
        {
            var transform = self.transform;
            var scale     = transform.localScale;
            scale = new
            (
                scale.x + x,
                scale.y,
                scale.z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// ローカル座標における Y 軸方向のスケーリング値を加算します
        /// </summary>
        public static void AddLocalScaleY( this Component self, float y )
        {
            var transform = self.transform;
            var scale     = transform.localScale;
            scale = new
            (
                scale.x,
                scale.y + y,
                scale.z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// ローカル座標における Z 軸方向のスケーリング値を加算します
        /// </summary>
        public static void AddLocalScaleZ( this Component self, float z )
        {
            var transform = self.transform;
            var scale     = transform.localScale;
            scale = new
            (
                scale.x,
                scale.y,
                scale.z + z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// Vector2 型でローカル座標におけるスケーリング値を加算します
        /// </summary>
        public static void AddLocalScale( this Component self, Vector2 v )
        {
            var transform = self.transform;
            var scale     = transform.localScale;
            scale = new
            (
                scale.x + v.x,
                scale.y + v.y,
                scale.z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// Vector3 型でローカル座標におけるスケーリング値を加算します
        /// </summary>
        public static void AddLocalScale( this Component self, Vector3 v )
        {
            self.transform.localScale += v;
        }

        /// <summary>
        /// ローカル座標におけるスケーリング値を加算します
        /// </summary>
        public static void AddLocalScale
        (
            this Component self,
            float          x,
            float          y
        )
        {
            var transform = self.transform;
            var scale     = transform.localScale;
            scale = new
            (
                scale.x + x,
                scale.y + y,
                scale.z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// ローカル座標におけるスケーリング値を加算します
        /// </summary>
        public static void AddLocalScale
        (
            this Component self,
            float          x,
            float          y,
            float          z
        )
        {
            var transform = self.transform;
            var scale     = transform.localScale;
            scale = new
            (
                scale.x + x,
                scale.y + y,
                scale.z + z
            );
            transform.localScale = scale;
        }
    }
}