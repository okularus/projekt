#pragma strict

function Start () {

}

function Update () {

if(Input.GetKeyUp("z")){
	//gameObject.GetComponent(ParticleSystem).
	 gameObject.GetComponent(ParticleSystem).Stop();
}

if(Input.GetKeyUp("x")){
	//gameObject.GetComponent(ParticleSystem).
	 gameObject.GetComponent(ParticleSystem).Play();
}

}