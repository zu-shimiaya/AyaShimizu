using UnityEngine;

public class objectcontroler : MonoBehaviour
{
    public float moveDistance = 10.0f; // 中心から左右に動く距離
    public float moveSpeed = 2.0f;    // 動く速さ

    private Vector3 centerPosition;

    void Start()
    {
        // 最初に置いた場所を中心として保存
        centerPosition = transform.position;
    }

    void Update()
    {
        // -1〜1の範囲でなめらかに変化する
        float x = Mathf.Sin(Time.time * moveSpeed) * moveDistance;

        // 中心位置から左右に動かす
        transform.position = centerPosition + new Vector3(x, 0f, 0f);
    }
}
