#!/bin/sh

apt update
apt install --yes \
ca-certificates \
curl \
gnupg-agent \
software-properties-common

curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo apt-key add -
sudo add-apt-repository \
  "deb [arch=amd64] https://download.docker.com/linux/ubuntudoc \
  $(lsb_release -cs) stable"

apt update

apt install --yes \
  docker-ce \
  containerd.io

  usermod -aG docker vagrant
  newgrp docker