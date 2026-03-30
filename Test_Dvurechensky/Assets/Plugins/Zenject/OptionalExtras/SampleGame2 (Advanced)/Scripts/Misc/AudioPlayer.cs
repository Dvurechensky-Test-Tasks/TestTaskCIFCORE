/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 марта 2026 12:19:05
 * Version: 1.0.221
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
