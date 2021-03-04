import React from 'react'

import { Avatar, Box, Text, Heading, Flex } from '@chakra-ui/react'

import { season, userInfo } from './constants'

const UserInfo: React.FC = () => {
  return (
    <Flex gridArea="userInfo">
      <Flex
        direction="column"
        align="center"
        justify="space-between"
        w="35%"
        bg="blue.900"
        borderRadius={4}
        border="1px solid"
        borderColor="blue.300"
        p={3}
      >
        <Flex
          bg="blue.300"
          w={8}
          h={8}
          mt={-3}
          borderRadius="0 0 4px 4px"
          align="center"
          justify="center"
        >
          <span>{season.icon}</span>
        </Flex>
        <Heading as="h3" fontSize="md" mt={1} color="blue.300">
          {season.name}
        </Heading>
        <Text fontSize="sm" color="blue.300">
          {season.year}
        </Text>
      </Flex>

      <Flex
        direction="column"
        justify="space-between"
        ml={6}
        flex="1"
        p={3}
        bg="gray.700"
        borderRadius={4}
        border="1px solid"
        borderColor="gray.100"
      >
        <Flex as="section">
          <Avatar
            name={userInfo.name}
            src={userInfo.picture}
            mr={2}
            w={35}
            h={35}
            border="3px solid white"
          ></Avatar>
          <Box>
            <Text as="h3" fontWeight="bold" fontSize="sm">
              @{userInfo.name}
            </Text>
            <Text as="p" fontSize="xs">
              @{userInfo.nickname}
            </Text>
          </Box>
        </Flex>

        <Box>
          <Flex align="center justify=" justify="space-between" mb="0.5px">
            <Text as="h3" fontSize="xs">
              Wins <strong>{userInfo.wins}</strong>
            </Text>
            <Text as="h3" fontSize="xs">
              <strong>{userInfo.loses}</strong> Loses
            </Text>
          </Flex>

          <Flex>
            <Box w="75%" h="1.5px" bg="gray.100" />
            <Box flex="1" h="1.5px" bg="gray.500" />
          </Flex>
        </Box>
      </Flex>
    </Flex>
  )
}

export default UserInfo
