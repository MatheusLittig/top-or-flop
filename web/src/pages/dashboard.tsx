import React from 'react'

import { Grid, GridItem, Heading } from '@chakra-ui/react'
import Head from 'next/head'
import Drawer from '../components/Drawer'

const Dashboard: React.FC = () => {
  return (
    <Grid
      h="100vh"
      templateColumns="repeat(4, 1fr)"
      templateRows="repeat(4, 1fr)"
      bg="gray.900"
      gap={4}
    >
      <Head>
        <Heading as="title">Dashboard</Heading>
      </Head>

      <GridItem rowSpan={4} colSpan={1} bg="gray.700" borderRadius={4}>
        <Drawer />
      </GridItem>
      {/* <GridItem rowSpan={1} colSpan={3} bg="gray.700" borderRadius={4} />
      <GridItem rowSpan={1} colSpan={2} bg="gray.700" borderRadius={4} />
      <GridItem rowSpan={1} colSpan={1} bg="gray.700" borderRadius={4} />
      <GridItem rowSpan={1} colSpan={2} bg="gray.700" borderRadius={4} />
      <GridItem rowSpan={1} colSpan={1} bg="gray.700" borderRadius={4} />
      <GridItem rowSpan={1} colSpan={1} bg="gray.700" borderRadius={4} />
      <GridItem rowSpan={1} colSpan={1} bg="gray.700" borderRadius={4} />
      <GridItem rowSpan={1} colSpan={1} bg="gray.700" borderRadius={4} /> */}
    </Grid>
  )
}

export default Dashboard
