import { extendTheme } from '@chakra-ui/react'

export const theme = extendTheme({
  config: {
    initialColorMode: 'dark',
    useSystemColorMode: false
  },
  fonts: {
    heading: 'Inter, sans-serif, system-font',
    body: 'Inter, sans-serif, system-font'
  }
})
