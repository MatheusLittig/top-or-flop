import React from 'react'

import { Divider, Flex, Text } from '@chakra-ui/react'

interface IDividerProps {
  title: string
}

const SectionDivider: React.FC<IDividerProps> = ({ title }) => {
  return (
    <Flex align="center">
      <Divider w={5} />
      <Text p={2} color="gray.500">
        {title}
      </Text>
      <Divider flex="1" />
    </Flex>
  )
}

export default SectionDivider
