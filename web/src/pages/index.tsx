import React from 'react'

import { Grid } from '@chakra-ui/react'
import Drawer from '../components/Drawer'
import Dashboard from './dashboard'

const Index: React.FC = () => {
  return (
    <Grid
      templateColumns="300px 1fr"
      templateAreas="
      'drawer route'
      "
      h="100vh"
      gap={4}
      p={6}
    >
      <Drawer />
      <Dashboard />
    </Grid>
  )
}

export default Index
