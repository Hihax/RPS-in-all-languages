#pragma once

#include <string>
#include <array>

class Rps 
{
private:
    std::string m_user{"null"};
    std::string m_bot{"null"};
    std::array<std::string, 3> m_choices = { "Rock", "Paper", "Scissors" };

public:
    Rps();
    void Start();
    void Verify();
    std::string Randomize();

};