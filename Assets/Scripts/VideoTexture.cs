using UnityEngine;

public class VideoTexture : MonoBehaviour {

public MovieTexture movieTexture;

void Start () {
movieTexture.loop = true;
GetComponent<Renderer>().material.mainTexture = movieTexture;
movieTexture.Play();

}}
