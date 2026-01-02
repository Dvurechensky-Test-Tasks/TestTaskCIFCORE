/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 января 2026 11:04:26
 * Version: 1.0.134
 */

using UnityEngine;

namespace Zenject.SpaceFighter
{
    public class AudioPlayer
    {
        readonly Camera _camera;

        public AudioPlayer(Camera camera)
        {
            _camera = camera;
        }

        public void Play(AudioClip clip)
        {
            Play(clip, 1);
        }

        public void Play(AudioClip clip, float volume)
        {
            _camera.GetComponent<AudioSource>().PlayOneShot(clip, volume);
        }
    }
}
