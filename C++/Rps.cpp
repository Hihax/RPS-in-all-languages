#include "Rps.h"

#include <iostream>
#include <string>
#include <array>

void Rps::Start()
{
    std::cout << "Rock, paper scissors !" << std::endl;
    std::cin >> m_user;
    std::cout << "User -> " << m_user << std::endl;
    Verify();
}

std::string Rps::Randomize()
{
    srand(time(0));
    std::string random;
    for(int i = 0; i < 3; i++)
    {
        random = m_choices[rand() % 3];
    }
    return random;
}

void Rps::Verify()
{
     m_bot = Randomize();

     std::cout << "Bot -> " << m_bot << std::endl << std::endl;

       if(m_bot == m_user)
        std::cout <<  "Equality !" << std::endl;
      else if
      (m_bot == "Rock" && m_user == "Paper")
         std::cout << "You win ! :)" << std::endl;
      else if 
      (m_bot == "Rock" && m_user == "Scissors")
         std::cout << "You lost ! :(" << std::endl;
      else if 
      (m_bot == "Paper" && m_user == "Rock")
         std::cout << "You lost ! :(" << std::endl;
      else if 
      (m_bot == "Paper" && m_user == "Scissors")
         std::cout << "You win ! :)" << std::endl;
      else if 
      (m_bot == "Scissors" && m_user == "Rock")
         std::cout << "You win ! :)" << std::endl;
      else if
      (m_bot == "Scissors" && m_user == "Paper")
        std::cout << "You lost ! :(" << std::endl;
}