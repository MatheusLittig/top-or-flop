import React from 'react'
import { AppProps } from 'next/app'
import { RecoilRoot } from 'recoil'

import { ChakraProvider } from '@chakra-ui/react'
import { theme } from '../styles/theme'

const MyApp: React.FC<AppProps> = ({ Component, pageProps }) => {
  return (
    <ChakraProvider resetCSS theme={theme}>
      <RecoilRoot>
        <Component {...pageProps} />
      </RecoilRoot>
    </ChakraProvider>
  )
}

export default MyApp
