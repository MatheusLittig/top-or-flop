import React from 'react'
import { AppProps } from 'next/app'
import { RecoilRoot } from 'recoil'

import { ChakraProvider } from '@chakra-ui/react'
import { theme } from '../styles/theme'
import { QueryClient, QueryClientProvider } from 'react-query'

const MyApp: React.FC<AppProps> = ({ Component, pageProps }) => {
  const queryClient = new QueryClient()

  return (
    <ChakraProvider resetCSS theme={theme}>
      <RecoilRoot>
        <QueryClientProvider client={queryClient}>
          <Component {...pageProps} />
        </QueryClientProvider>
      </RecoilRoot>
    </ChakraProvider>
  )
}

export default MyApp
