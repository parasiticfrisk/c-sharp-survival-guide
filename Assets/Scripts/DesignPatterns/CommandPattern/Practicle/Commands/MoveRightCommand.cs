﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.DesignPatterns.Command.Practicle
{
    public class MoveRightCommand : ICommand
    {
        private Transform _player;
        private float _speed;

        public MoveRightCommand(Transform player, float speed)
        {
            this._player = player;
            this._speed = speed;
        }

        public void Execute()
        {
            _player.Translate(Vector3.right * _speed * Time.deltaTime);
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}