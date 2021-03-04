import React from 'react'

import { Box, Flex, Heading, Text } from '@chakra-ui/react'

const FeatureTitle: React.FC = () => {
  return (
    <Box>
      <Heading as="h3" fontSize="md" fontWeight="700" letterSpacing={2}>
        ANIME SEASON
      </Heading>

      <Heading as="h1" fontWeight="900" display="flex">
        <Text mr={2} color="blue.500">
          TOP
        </Text>
        OR
        <Text ml={2} color="red.500">
          FLOP
        </Text>
      </Heading>

      <Flex>
        <Box w="50%" h={1} bg="blue.500" />
        <Box flex="1" h={1} bg="red.500" />
      </Flex>
    </Box>
  )
}

export default FeatureTitle
