#ifndef IGLOO_KATAS_TEST_H
#define IGLOO_KATAS_TEST_H

#include <igloo/igloo.h>
#include <string>
#include <sstream>

namespace igloo
{
    template < typename T > std::string to_string( const T& n )
    {
      std::ostringstream stm;
      stm << n;
      return stm.str();
    }
}

using namespace igloo;

#endif
