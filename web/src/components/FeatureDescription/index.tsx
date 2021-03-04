import React from 'react'

import { Box, Flex, Heading, Text } from '@chakra-ui/react'
import { description } from './constants'

const FeatureDescription: React.FC = () => {
  return (
    <Flex gridArea="desc" bg="gray.700" borderRadius={4} p={4}>
      <Box>
        <Heading as="h3" fontSize="md">
          {description.title}
        </Heading>
        <Text mt={1} fontSize="sm">
          {description.description}
        </Text>
      </Box>
    </Flex>
  )
}

export default FeatureDescription
