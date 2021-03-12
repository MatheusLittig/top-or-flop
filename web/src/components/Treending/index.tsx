import React, { useEffect, useState } from 'react'

import { Box, Flex, Heading, List, ListItem, Text } from '@chakra-ui/react'
import { getAnimeTreending } from '../../services/JikanAPI'

interface AnimeTreending {
  title: string
  score: number | null
  studio: string[]
  imageUrl: string
  genres: string[]
}

const Treending: React.FC = () => {
  const [treendingList, setTreendinList] = useState<AnimeTreending[]>([])

  useEffect(() => {
    getAnimeTreending(2021, 'winter').then(res =>
      res.map(anime =>
        setTreendinList([
          {
            title: anime.title,
            studio: anime.producers.map(producer => producer.name),
            score: anime.score,
            genres: anime.genres.map(genre => genre.name),
            imageUrl: anime.image_url
          }
        ])
      )
    )
  }, [])

  return (
    <Box gridArea="trending" bg="gray.700" p={3}>
      {treendingList.map(anime => (
        <Flex key={anime.title} align="center" justify="space-between" h="100%">
          <Box>
            <Heading as="h3" fontSize="md">
              TREENDING
            </Heading>

            <Heading
              as="h2"
              fontSize="xl"
              color="blue.300"
              textTransform="uppercase"
            >
              {anime.title}
            </Heading>

            <Flex mt={3}>
              <Text
                fontSize="md"
                p={3}
                fontWeight="700"
                border="1px solid"
                borderColor="blue.300"
                color="blue.300"
                borderRadius={4}
              >
                {anime.score}
              </Text>

              <Flex flexDir="column" justify="space-between" ml={3}>
                <Text fontSize="sm">
                  <strong>Producers: </strong>
                  {anime.studio}
                </Text>

                <Text fontSize="sm" display="flex" align="center">
                  <strong>Genres:</strong>

                  <List ml={2}>
                    {anime.genres.map(genre => (
                      <ListItem
                        bg="blue.500"
                        p="5px 8px"
                        borderRadius={4}
                        display="inline"
                        mr={2}
                        key={genre}
                      >
                        {genre}
                      </ListItem>
                    ))}
                  </List>
                </Text>
              </Flex>
            </Flex>
          </Box>

          <Box
            bg="white"
            w="20%"
            h="100%"
            borderRadius={4}
            backgroundImage={`url(${anime.imageUrl})`}
            backgroundPosition="center"
            backgroundSize={180}
          />
        </Flex>
      ))}
    </Box>
  )
}

export default Treending
